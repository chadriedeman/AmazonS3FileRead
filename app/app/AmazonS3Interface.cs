using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace app
{
    public class AmazonS3Interface
    {
        private static readonly IAmazonS3 _client = new AmazonS3Client(RegionEndpoint.USEast1);

        public async Task<List<string>> GetZippedFileContentsFromS3Bucket(string bucketName, string keyName)
        {
            try
            {
                var request = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName
                };

                using var response = await _client.GetObjectAsync(request);

                using var responseStream = response.ResponseStream;

                Stream unzippedResponseStream;

                var archive = new ZipArchive(responseStream);

                var entries = new List<string>();

                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    unzippedResponseStream = entry.Open();

                    using var reader = new StreamReader(unzippedResponseStream);

                    entries.Add(reader.ReadToEnd());
                }

                return entries;
            }

            catch (Exception ex)
            {
                return null; // TODO
            }
        }
    }
}
