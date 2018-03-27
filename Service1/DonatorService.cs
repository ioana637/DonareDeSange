using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DonatorService
    {
        public UserDonator GetUserDonator(string UserName)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                UserDonator user = unitOfWork.UserDonatorRepo.GetBy(x => x.Username == UserName);
                if (user == null) { throw new ValidationException(); }
                return user;
            }
        }

        public static bool LogInUserDonator(string userName, string password)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                UserDonator user = unitOfWork.UserDonatorRepo.GetBy(x => x.Username == userName);
                if (user.Parola == password)
                {
                    return true;
                }
                return false;
            }
        }

        public void RegisterDonator(string userName, string password, string nume, string prenume, string sex, DateTime dataNastere, string domiciliu, string localitate, string judet, string resedinta, string localitateResedinta, string judetResedinta, string telefon, string email, float greutate, int interventiiUltimele6Luni, int subTratament)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Donator donator = new Donator(nume, prenume, sex, dataNastere, domiciliu, localitate, judet, resedinta, localitateResedinta, judetResedinta, telefon, email, greutate, interventiiUltimele6Luni, subTratament);
                unitOfWork.DonatorRepo.Save(donator);
                UserDonator user = new UserDonator(userName, password);
                unitOfWork.UserDonatorRepo.Save(user);
                unitOfWork.Save();
                donator = unitOfWork.DonatorRepo.GetBy(d => d.Email.Equals(email));
                user = unitOfWork.UserDonatorRepo.GetBy(u => u.Username.Equals(userName));
                donator.UserDonator = user;
                user.Donator = donator;
                unitOfWork.Save();

            }
        }
    }
}
