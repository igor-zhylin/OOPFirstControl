﻿using Parser;
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
                            Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m
                            Data:DataFile.dat(11Mb);Some HereData;Lol;OneMore";
            Parse parse = new Parse();
            metadata = parse.RunParser(text);


            Console.ReadKey();
        }
    }
}
