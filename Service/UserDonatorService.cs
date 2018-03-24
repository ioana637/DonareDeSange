using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class UserDonatorService
    {
        public static UserDonator GetUserDonator(string UserName)
        {
            using(UnitOfWork unitOfWork = new UnitOfWork())
            {
                UserDonator user = unitOfWork.UserDonatorRepo.GetBy(x => x.Username == UserName);
                if(user == null) { throw new ValidationException(); }
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

        public static void RegisterUserDonator(string userName, string password, string nume, string prenume, string sex, DateTime dataNastere, string domiciliu, string localitate, string judet, string resedinta, string localitateResedinta, string judetResedinta, string telefon, string email, float greutate, bool interventiiUltimele6Luni, bool subTratament)
        {
            using(UnitOfWork unitOfWork = new UnitOfWork())
            {
                UserDonator user = new UserDonator(userName, password);
                unitOfWork.UserDonatorRepo.context.Add(user);
                unitOfWork.UserDonatorRepo.context.SaveChanges();
                Donator donator = new Donator(nume, prenume, sex, dataNastere, domiciliu, localitate, judet, resedinta, localitateResedinta, judetResedinta, telefon, email, greutate, interventiiUltimele6Luni, subTratament);
                unitOfWork.DonatorRepo.context.Add(donator);
                unitOfWork.DonatorRepo.context.SaveChanges();
            }
        }

    }
}
