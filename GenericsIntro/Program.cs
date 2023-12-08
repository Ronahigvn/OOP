using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ronahi");
            Console.WriteLine(isimler.Length);
            isimler.Add("Ronahi");
            Console.WriteLine(isimler.Length);
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
