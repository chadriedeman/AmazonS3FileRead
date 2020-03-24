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


            return null; // TODO
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
