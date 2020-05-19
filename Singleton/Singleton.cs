using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        string path = @"C:\Users\Tin August Levacic\Desktop\Singleton\Users.txt";
        private static Singleton instance;
        private Singleton() { }


        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

        public void writeToFile(String userInput)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                    sw.WriteLine(userInput);
            }
        }
    }
}
