using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string location = Directory.GetCurrentDirectory() + "\\MyFile.txt";
            ReadFile(location);

            // Process.Start("explorer.exe", @"c:\temp");
            Process.Start(Directory.GetCurrentDirectory());
            Console.WriteLine("\nPress any key to encrypt - watch file getting green on the folder");
            Console.ReadLine();
            EncryptFile(location);

            Console.WriteLine("\nPress any key to encrypt - watch file getting black on the folder");
            Console.ReadLine();
            DecryptFile(location);
        }

        private static void DecryptFile(string location)
        {
            File.Encrypt(location);
        }

        private static void EncryptFile(string location)
        {
            File.Decrypt(location);
        }

        private static void ReadFile(string location)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(location);
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }        
        }

    }
}
