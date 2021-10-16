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
        bool CheckPermission(UserModel userModel);
        UserModel GetUser(string ID);
        UserModel UpdateUser(UserModel userModel);

    }
}
