using Amazon;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Transfer;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekognitionCustomLabels
{
    public partial class FrmMain : Form
    {

        private AWSCredentials _awsCredentials;
        private readonly RegionEndpoint _region = RegionEndpoint.USEast1;
        private const string PROJECT_ARN = "arn:aws:rekognition:us-east-1:221892253117:project/nescau-toddy-cocacola/version/nescau-toddy-cocacola.2021-05-06T07.48.11/1620298091590";
        private const string BUCKET_NAME = "ia-custom-labels-images";

        public FrmMain()
        {
            InitializeComponent();
        }


        private void GetCredentials()
        {
            var chain = new CredentialProfileStoreChain();

            // Get credentials in machine
            if (!chain.TryGetAWSCredentials("AWS Educate profile", out _awsCredentials))
            {
                MessageBox.Show("Error fetching credentials");
            }
        }


        private async Task<bool> UploadImageToS3(string file)
        {
            GetCredentials();

            try
            {
                AmazonS3Client s3Client = new AmazonS3Client(_awsCredentials, _region);
                TransferUtility fileTransferUtility = new TransferUtility(s3Client);

                await fileTransferUtility.UploadAsync(file, BUCKET_NAME);

                return true;
            }
            catch (AmazonS3Exception ex)
            {
                MessageBox.Show($"Error encountered on server. Message: '{0}' when writing an object {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown encountered on server. Message: '{0}' when writing an object {ex.Message}");
                return false;
            }
        }

        private async void BtnCarregar_Click(object sender, EventArgs e)
        {
            DialogResult result = OfdImagem.ShowDialog();

            if (result == DialogResult.OK)
            {
                PBoxImage.Load(OfdImagem.FileName);

                await UploadImageToS3(OfdImagem.FileName);
                await ProcessImageWithCustomLabel(OfdImagem.FileName);
            }
        }

        private async Task ProcessImageWithCustomLabel(string fileName)
        {
            try
            {
                AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient(_awsCredentials, _region);

                RtxtbRetorno.Clear();

                RtxtbRetorno.Text = "Processando imagem...";

                var request = new DetectCustomLabelsRequest()
                {
                    Image = new Amazon.Rekognition.Model.Image()
                    {
                        S3Object = new S3Object()
                        {
                            Bucket = BUCKET_NAME,
                            Name = Path.GetFileName(fileName),
                        },

                    },
                    ProjectVersionArn = PROJECT_ARN,
                };

                DetectCustomLabelsResponse response = await rekognitionClient.DetectCustomLabelsAsync(request);

                RtxtbRetorno.Clear();

                foreach (CustomLabel customLabel in response.CustomLabels)
                {
                    RtxtbRetorno.AppendText(JsonConvert.SerializeObject(customLabel, Formatting.Indented));

                    Pen pen = new Pen(Color.Red);

                    Graphics graphics = PBoxImage.CreateGraphics();

                    var boundingBox = customLabel.Geometry.BoundingBox;
                    var imageDimensions = PBoxImage.Image;

                    graphics.DrawRectangle(pen,
                                           boundingBox.Left * imageDimensions.Width,
                                           boundingBox.Top * imageDimensions.Height,
                                           boundingBox.Width * imageDimensions.Width,
                                           boundingBox.Height * imageDimensions.Height);
                }

                if (response.CustomLabels.Count <= 0)
                {
                    RtxtbRetorno.AppendText("Não foi encontrado nenhum label para a imagem selecionada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
