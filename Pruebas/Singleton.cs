using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Singleton
    {
        private static Singleton instance = null;
        public string msg = "";
        protected Singleton()
        {
            this.msg = "Hola!";
        }

        public static Singleton Instance
        {

            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
