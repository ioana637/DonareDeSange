using CentruDeTransfuzie.model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1
{
    public class AdminService
    {
        public int Login(String username, String password)
        {
            Admin admin = GetAdminByUsername(username);
            if (admin == null) return -1;
            if (admin.Parola.Equals(password))
                return admin.Id;
            else return -1;
        }

        private Admin GetAdminByUsername(string username)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {

                Admin admin = unitOfWork.AdminRepo.GetBy((a) => a.Username.Equals(username));
                return admin;
            }
        }
    }
}
