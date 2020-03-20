using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Console.WriteLine(Singleton.Instance.msg);
            Singleton.Instance.msg = "prueba";
            Console.WriteLine(Singleton.Instance.msg);
            
            Console.ReadKey();

        }

    }
}
