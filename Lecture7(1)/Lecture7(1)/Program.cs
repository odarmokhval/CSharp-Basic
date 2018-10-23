using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input file operation create/delete/copy <filepath>");
            var commandLine = Console.ReadLine();// @"create c:\temp\test.txt" delete c:\temp\test.txt, copy c:\temp\test.txt c:\tremp1\test.txt
            var commandArray = commandLine.Trim().Split(' ');
            var command = commandArray[0];
            var filePath = commandArray[1];
            var fileName = Path.GetFileName(filePath);


            if (filePath.Length > 256)
            {
                Console.WriteLine("File path is too long");
                Console.ReadKey();
            }


            switch (command)
            {
                case "create":

                    if (!IsFileExists(filePath))
                    {
                        CreateFile(filePath, "Olia's test text");
                    }
                    else
                    {
                        Console.WriteLine("Do you want to overwrite? y/n");
                        if (Console.ReadLine().ToLower().Equals("y") ? true : false)
                        {
                            CreateFile(filePath, "Olia's test text overwriten");
                        }
                        else
                        {
                            Console.ReadKey();
                        }
                    }
                    break;
                case "delete":
                     if (IsFileExists(filePath))
                    {
                        DeleteFile(filePath);
                        Console.WriteLine("File was successfully deleted");
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                    break;
                case "copy":
                    if (IsFileExists(filePath))
                    {
                        Console.WriteLine("Please enter a new file name: ");
                        var fileNewName = Console.ReadLine();
                        CopyFile(fileName, fileNewName);

                        if (fileName == fileNewName)
                        {
                            Console.WriteLine("You entered previous file name, enter valid");
                        }
                        else
                        {
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                    break;
            }

        }

        static void CreateFile(string filePath, string content)
        {
            FileStream fileStream = File.Create(filePath);
            byte[] array = Encoding.Default.GetBytes(content);
            fileStream.Write(array, 0, array.Length);
            fileStream.Close();
            fileStream.Dispose();
        }

        static void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }

        static void CopyFile(string fileName, string fileNewName)
        {
            File.Copy(fileName, fileNewName);
        }

        static bool IsFileExists(string filePath)
        {
            return File.Exists(filePath);
        }

    }
}