using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main1(string[] args)
        {
            dosyadanOku();
            Console.ReadLine();
        }
        private static void dosyayaYaz()
        {
            string dosya_yolu = @"E:\ConsoleApp1\ConsoleApp1\bin\Debug\cmd.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            
            StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("1.Satır:Merhaba");
            //sw.WriteLine("2.Satır:Dünya");
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void dosyadanOku()
        {
            string dosya_yolu = @"E:\ConsoleApp1\ConsoleApp1\bin\Debug\cmd.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
           
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                Console.WriteLine(yazi);
                yazi = sw.ReadLine();
            }
           
            sw.Close();
            fs.Close();
        }
    }
}
