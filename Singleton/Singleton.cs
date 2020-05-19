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

        public void processData(String Username, String Password)
        {
            if (!File.Exists(path))
            {
                try
                {
                    String userInput = Username + ";" + Password;
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(userInput);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            else if (File.Exists(path))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] result = line.Split(';');
                            validate(Username, Password, result);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void validate(String Username, String Password, String[] result)
        {
            if (String.Equals(Username, result[0]))
            {
                if(String.Equals(Password, result[1]))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
