using app.Models;
using System.Collections.Generic;

namespace app
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var s3Interface = new AmazonS3Interface();

            var rawZippedFiles = s3Interface.GetZippedFileContentsFromS3Bucket("principalinterview", "alkirempi.zip")
                .Result;

            var zippedFileHelper = new ZippedFileHelper();

            var zippedFiles = new List<ZippedFile>();

            foreach (var rawZippedFile in rawZippedFiles)
            {
                zippedFiles.Add(zippedFileHelper.ParseZippedFileContentsFromString(rawZippedFile));
            }

            var mergedZippedFile = zippedFileHelper.MergeZippedFilesOnCommonColumn(zippedFiles);

            zippedFileHelper.PrintZippedFileContents(mergedZippedFile);
        }
    }
}
