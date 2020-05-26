using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        public String username="";
        public String password = "";
        private static Singleton instance;
        private Singleton() { }

        public String Username { get { return username; } }
        public String Password { get { return password; } }

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

        public ValidationState ProcessData(String Username, String Password)
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
                    username = Username;
                    password = Password;
                    return ValidationState.True;
                }
                catch(Exception)
                {
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
                            bool validated= Validate(Username, Password, result);
                            if (validated)
                            {
                                username = Username;
                                password= Password;
                                return ValidationState.True;
                            }
                            else return ValidationState.False;
                        }
                    }
                }
                catch (Exception)
                {
                    return ValidationState.Error;
                }
            }
            return ValidationState.Error;
        }

        private bool Validate(String Username, String Password, String[] result)
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
