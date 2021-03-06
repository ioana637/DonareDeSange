﻿using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class UserMedicService
    {
        public UserMedicService() { }

        public UserMedic GetUserMedicByUsername(String username)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                UserMedic user = unitOfWork.UserMedicRepo.GetBy(m => m.Username.Equals(username));
                return user;
            }
        }

        public bool Login(String username, String password)
        {
            
            UserMedic um = GetUserMedicByUsername(username);
            if (um == null) return false;
            if (um.Parola.Equals(password)) return true;
            else return false;
            
            
        }
    }
}

