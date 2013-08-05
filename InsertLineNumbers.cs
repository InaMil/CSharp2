//3.Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.IO;

class InsertLineNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the full path (including file name) to the text file you want to read and print");
        StreamReader readTxt = new StreamReader(Console.ReadLine());

        Console.WriteLine("Please enter the full path to the resulting file ");
        string resultFile = Console.ReadLine();

        using (readTxt)
        {
            StreamWriter writeNewFile = new StreamWriter(resultFile);
            using (writeNewFile)
            {
                string line = readTxt.ReadLine();
                int lineCounter = 1;
                while (line != null)
                {
                    writeNewFile.WriteLine("Line" + lineCounter + " " + line);
                    line = readTxt.ReadLine();
                    lineCounter++;
                }
            }
        }
        Console.WriteLine("The new file is writen!");
    }
}
