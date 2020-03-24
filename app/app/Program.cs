namespace app
{
    public class Program
    {

        public static void Main(string[] args)
        {

            var s3Interface = new AmazonS3Interface();

            var zippedFiles = s3Interface.GetZippedFileContentsFromS3Bucket("principalinterview", "alkirempi.zip")
                .Result;

            // TODO:
        }
    }
}
