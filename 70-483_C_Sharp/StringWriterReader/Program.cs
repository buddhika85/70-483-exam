using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite rw = new ReadWrite();
            rw.ReadData();
            rw.WriteData();
            
            Console.ReadKey();
        }

        
    }

    public class ReadWrite
    {
        StringBuilder sb = new StringBuilder();

        public void ReadData()
        {
            StringWriter sw = new StringWriter(sb);
            try
            {                
                Console.WriteLine("Enter your name : ");
                string name = Console.ReadLine();
                sw.WriteLine("name - " + name);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sw.Flush();
                sw.Close();
            }
        }

        public void WriteData()
        {
            Console.WriteLine();
            Console.WriteLine("Reading information \n");
            StringReader sr = new StringReader(sb.ToString());
            try
            {                
                while (sr.Peek() > -1)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {              
                sr.Close();
            }
        }

    }

}
