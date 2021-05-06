using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Transfer;
using System;
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
            } // HACKEADA
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

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            DialogResult result = OfdImagem.ShowDialog();

            if (result == DialogResult.OK)
            {
                PBoxImage.Load(OfdImagem.FileName);

               // await UploadImageToS3(OfdImagem.FileName);
                //await DetectFaces(OfdImagem.FileName);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

        }

        //private async Task DetectFaces(string image)
        //{
        //    AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient(_awsCredentials, _region);

        //    DetectFacesRequest detectFacesRequest = new DetectFacesRequest()
        //    {
        //        Image = new Amazon.Rekognition.Model.Image()
        //        {
        //            S3Object = new S3Object()
        //            {
        //                Name = Path.GetFileName(image),
        //                Bucket = BUCKET_NAME,
        //            }
        //        },
        //        Attributes = new List<string> { "ALL" },
        //    };

        //    try
        //    {
        //        DetectFacesResponse detectFacesResponse = await rekognitionClient.DetectFacesAsync(detectFacesRequest);
        //        bool hasAll = detectFacesRequest.Attributes.Contains("ALL");

        //        rtbRetorno.Clear();

        //        foreach (FaceDetail face in detectFacesResponse.FaceDetails)
        //        {
        //            rtbRetorno.AppendText(JsonConvert.SerializeObject(face, Formatting.Indented));

        //            Pen pen = new Pen(Color.Red);

        //            Graphics graphics = pictureBox1.CreateGraphics();
        //            graphics.DrawRectangle(pen,
        //                                   face.BoundingBox.Left * pictureBox1.Image.Width,
        //                                   face.BoundingBox.Top * pictureBox1.Image.Height,
        //                                   face.BoundingBox.Width * pictureBox1.Image.Width,
        //                                   face.BoundingBox.Height * pictureBox1.Image.Height);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        rtbRetorno.AppendText(ex.Message);
        //    }
        //}

    }
}
