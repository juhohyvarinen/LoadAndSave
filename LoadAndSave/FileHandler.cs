using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
namespace LoadAndSave
{
    public class FileHandler
    {
        public string filePath = @"E:\Testikansio\kansio3\tekstitiedosto";

        public void PersonTostring()
        {

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("Hessu,Hopo,Ankkalinna,false,4");

            File.WriteAllLines(filePath, lines);

            Console.ReadLine();
            
        }
    }
}
        

