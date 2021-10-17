using _31927_TextEditor.Interface;
using _31927_TextEditor.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31927_TextEditor.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool CreateUser(UserModel userModel) {

            //if (GetUser(userModel.Username) != null) {
            //    return false; //User with same username already exists
            //}

           string fileName = AppDomain.CurrentDomain.BaseDirectory + @"\Users\login.txt";


            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                //Write passed model
                sw.WriteLine("{0},{1},{2},{3},{4},{5}", userModel.Username, userModel.Password, userModel.Permission, userModel.FirstName, userModel.LastName, userModel.DOB);
              
                sw.Close();

            }

            return true;
        }

        public UserModel GetUser(string username)
        {
            return null;
        }

        public string CheckPermission(string username, string password) {

            List<(string, string, string)> credentialsFromFile = new List<(string, string, string)>();
            string line;
            string[] tempCredentials;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Users\login.txt"); // Make dynamic
                //Read the first line of text
                line = sr.ReadLine();

                while (line != null)
                {
                    tempCredentials = line.Split(',');
                    credentialsFromFile.Add((tempCredentials[0], tempCredentials[1], tempCredentials[2]));

                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            foreach ((string, string, string) credential in credentialsFromFile)
            {
                //Compares the password
                if (username == credential.Item1 && password == credential.Item2)
                {
                    return credential.Item3;
                }
            }

            return "";
        }

        public bool CheckPassword(string username, string password)
        {

            List<(string, string)> credentialsFromFile = new List<(string, string)>();
            string line;
            string[] tempCredentials;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Credentials\login.txt"); // Make dynamic
                //Read the first line of text
                line = sr.ReadLine();

                while (line != null)
                {
                    tempCredentials = line.Split(',');
                    credentialsFromFile.Add((tempCredentials[0], tempCredentials[1]));

                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            foreach ((string, string) credential in credentialsFromFile)
            {
                //Compares the password
                if (username == credential.Item1 && password == credential.Item2)
                {
                    return true;
                }
            }
            return false;
        }

        public UserModel UpdateUser(UserModel userModel) {
            return null;
        }

    }
}
