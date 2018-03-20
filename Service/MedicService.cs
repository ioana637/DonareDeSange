using Repository;
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
            using (UnitOfWork unitOfWork=new UnitOfWork())
            {
                UserMedic user = unitOfWork.UserMedicRepo.GetBy(m => m.Username.Equals(username));
                if (user == null) throw new ValidationException("nu exista username");
                return user;
            }
        }
    }
}
