using _31927_TextEditor.Interface;
using _31927_TextEditor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31927_TextEditor.Repository
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(UserModel userModel) { 

        }

        public bool CheckPermission(UserModel userModel) {

            return false;
        }

        public UserModel GetUser(string ID) {

            return null;
        }

        public UserModel UpdateUser(UserModel userModel) {
            return null;
        }

    }
}
