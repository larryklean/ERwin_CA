﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERwin_CA
{/// <summary>
/// Manage the logging system.
/// </summary>
    static class Logger
    {
        private static string FileName;
        private static FileInfo FileInfos;
        //private static StreamWriter StrWr;
        private static string FileNameStream;
        public static void Initialize(string fileName)
        {
            Timer.SetFirstTime(DateTime.Now);
            FileName = fileName;
            FileInfos = new FileInfo(FileName);
            FileNameStream = FileInfos.DirectoryName + 
                             @"\" +
                             Path.GetFileNameWithoutExtension(FileInfos.FullName) + 
                             "_" +
                             Timer.GetTimestampDay(DateTime.Now) + 
                             ".txt";
            //StrWr = File.AppendText(FileNameStream);
        }
        public static void PrintL(string text)
        {
            string line = Timer.GetTimestampPrecision(DateTime.Now) + "    " + text;
            using ( StreamWriter StrWr = File.AppendText(FileNameStream))
            {
                StrWr.WriteLine(line);
                StrWr.Close();
            }
        }
        public static void PrintC(string text)
        {
            string line = Timer.GetTimestampPrecision(DateTime.Now) + "    " + text;
            Console.WriteLine(line);
        }

        public static void PrintLC(string text, int level = 1)
        {
            if (!(level > ConfigFile.LOG_LEVEL))
            {
                string line = Timer.GetTimestampPrecision(DateTime.Now);
                if (!(level >= 0 && level <= 6))
                    level = 1;
                for (int x = 0; x < level; x++)
                {
                    line = line + "    ";
                }
                line = line + text;
                Console.WriteLine(line);
                using (StreamWriter StrWr = File.AppendText(FileNameStream))
                {
                    StrWr.WriteLine(line);
                    StrWr.Close();
                }
            }
        }

        public static void PrintF(string fileName, string text, bool timestamp = false)
        {
            string line = (timestamp ? (Timer.GetTimestampPrecision(DateTime.Now) + "    ") : "") +
                        text;
            FileInfo file = new FileInfo(fileName);
            DirectoryInfo dir = new DirectoryInfo(file.DirectoryName);
            if (dir.Exists)
                using (StreamWriter StrWr = File.AppendText(fileName))
                {
                    StrWr.WriteLine(line);
                    StrWr.Close();
                }
        }
    }
}
