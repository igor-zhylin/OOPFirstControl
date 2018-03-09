using Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FileMetaData.MetaData> metadata = new List<FileMetaData.MetaData>();
            String text = @"Text: file.txt(6B); Some string content
                            Image: img.bmp(19MB); 1920х1080
                            Text:data.txt(12B); Another string
                            Text:data1.txt(7B); Yet another string
                            Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";
            Parse parse = new Parse();
            metadata = parse.RunParser(text);

            foreach (FileMetaData.MetaData data in metadata)
            {
                Console.WriteLine(
                    GetCategoryName(data.Format)
                    + Environment.NewLine
                    + data.ToString() 
                    + Environment.NewLine);
            }
            Console.ReadKey();
        }

        private static string GetCategoryName(string fileType)
        {
            switch (fileType.ToLower())
            {
                case "text": return "Text File: ";
                case "movie": return "Movie File: ";
                case "image": return "Image: ";
                default:
                    return "UnknownType: ";
            }

        }
    }
}