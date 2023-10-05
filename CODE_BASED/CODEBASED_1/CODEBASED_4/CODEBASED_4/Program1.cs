using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CODEBASED_4
{
        class Program1
        {
            static void Main()
            {
                string filePath = @"D:\csharp_assignments\CODE_BASED\CODEBASED_4\CODEBASED_4\CODEBASED_Sample_text.txt";
                string textToAppend = "this is a sample text for code based Test_4";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(textToAppend);
                    writer.Close();
                }

                Console.WriteLine("File has been Created and Text has been appended to that particular file.");
                Console.ReadLine();
            }
        }
    }
