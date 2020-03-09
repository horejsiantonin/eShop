using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Logic
{
    public static class UserLogic
    {
        public static int CreateUser(int Id, string Username, string Password, string myToken)
        {
            UserModel data = new UserModel
            {
                id = Id,
                user_name = Username,
                password = Password,
                Token = myToken,
            };

            
        }
    }
}