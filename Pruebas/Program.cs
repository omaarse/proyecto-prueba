﻿using System;
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
<<<<<<< HEAD
            Singleton.Instance.msg = "prueba git hub 3 sin login!";
=======
            Singleton.Instance.msg = "prueba git hub 3 con login!!!";
>>>>>>> login
            Console.WriteLine(Singleton.Instance.msg);
            
            Console.ReadKey();

        }

    }
}
