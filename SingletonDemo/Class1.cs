using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    internal class Class1
    {
        private static Class1 instance = null;
        private static readonly object padlock= new object(); 

        private Class1()
        {
            Console.WriteLine("Constructor Called");
        }

        public static Class1 Instance
        {
            get
            {
                lock (padlock)
                {
                    Console.WriteLine("Instance Called");
                    if (instance == null)
                    {
                        instance = new Class1();
                    }
                    return instance;
                }

            }
        }
    }
}
