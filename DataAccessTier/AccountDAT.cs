﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DataAccessTier
{
    class AccountDAT
    {
        public AccountDAT() { }
        public bool GetUserByUsernameAndPassword(string username,string password)
        {
            string[] users = { "admin", "staff1", "staff2" };
            string[] passwords = { "12345678", "kokoko", "123123123" };

            for (int i=0;i<3;i++)
            {
                if (users[i] == username && passwords[i]==password) {
                return true;
                }
            }
            

            return false;
        }
    }
}
