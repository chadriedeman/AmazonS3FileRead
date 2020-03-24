using app.Models;
using System;
using System.Linq;

namespace app
{
    public class ZippedFileParser
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
    }
}
