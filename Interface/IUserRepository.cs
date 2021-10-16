using _31927_TextEditor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31927_TextEditor.Interface
{
    public interface IUserRepository
    {
        void CreateUser(UserModel userModel);
        string CheckPermission(string userName, string password);
        UserModel GetUser(string ID);
        UserModel UpdateUser(UserModel userModel);

    }
}
