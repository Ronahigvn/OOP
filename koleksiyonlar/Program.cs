using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //toplu commet alma kisayolu:ctl+k && ctrl+c
            //string[] isimler = new string[] { "Ronahi", "A.Roni", "Rohat" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "Guven";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);//bos gelir cunku new dedikten sonra bombos bir alandan 0. indexsi getiri o yuzden bize Ronahi degil boslugu gonderir.
            List<string>isimler2 = new List<string> { "Ronahi", "A.Roni", "Rohat" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Guven");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            Console.ReadLine();
        }
    }
}
