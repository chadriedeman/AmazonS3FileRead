using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace app
{
    public class ZippedFileHelper
    {
        public ZippedFile ParseZippedFileContentsFromString(string rawZippedFileContents)
        {
            var zippedFile = new ZippedFile();

            var rows = rawZippedFileContents.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None)
                .ToList();

            zippedFile.Columns = rows[0].Split(',')
                .ToList();

            zippedFile.Rows = rows.GetRange(1, rows.Count - 1);

            return zippedFile;
        }

        public ZippedFile MergeZippedFilesOnCommonColumn(List<ZippedFile> zippedFiles)
        {
            if (!zippedFiles.Any())
                return new ZippedFile();

            var mergedZipFile = new ZippedFile
            {
                Columns = zippedFiles[0].Columns,
                Rows = zippedFiles[0].Rows
            };

            foreach (var column in zippedFiles[0].Columns)
            {
                foreach (var zippedFile in zippedFiles.GetRange(1, zippedFiles.Count - 1)) 
                {
                    var matchingColumn = zippedFile.Columns.FirstOrDefault(i => i == column);

                    if (matchingColumn != null)
                    {
                        var indexOfMatchingColumn = zippedFile.Columns.IndexOf(matchingColumn);

                        // TODO: Add that column's data to the merged zip file
                    }
                }
            }

            return mergedZipFile; 
        }

        public void PrintZippedFileContents(ZippedFile zippedFile)
        {
            Console.WriteLine(string.Join(',', zippedFile.Columns));

            foreach(var row in zippedFile.Rows)
            {
                Console.WriteLine(string.Join(',', zippedFile.Rows));
            }
        }
    }
}
