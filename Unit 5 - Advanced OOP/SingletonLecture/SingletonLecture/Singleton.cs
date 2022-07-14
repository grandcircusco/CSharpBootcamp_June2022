using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLecture
{
    internal class Singleton
    {
        //This will remain null, until an instance is created
        private static Singleton instance = null;
        //private constructor so there is no public one
        private Singleton()
        {

        }

        //Only way to get an instance of the class
        public static Singleton getInstance()
        {
            if(instance == null)
            {
                Console.WriteLine("creating new instance");
                instance = new Singleton();
            }

            return instance;
        }

    }
}
