using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public enum ValidationState{
        True,
        False,
        Error
    };

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

        public ValidationState processData(String Username, String Password)
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
                    return ValidationState.True;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    return ValidationState.Error;
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
                            bool validated= validate(Username, Password, result);
                            if (validated)
                            {
                                //Correct data
                                return ValidationState.True;
                            }
                            else return ValidationState.False;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                    return ValidationState.Error;
                }
            }
            return ValidationState.Error;
        }

        private bool validate(String Username, String Password, String[] result)
        {
            if (String.Equals(Username, result[0]))
            {
                if(String.Equals(Password, result[1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
