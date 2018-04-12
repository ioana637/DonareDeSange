using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public bool LogInUserDonator(string userName, string password)
        {

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                string encryptedPassword = EncryptPassword(password);

                UserDonator user = unitOfWork.UserDonatorRepo.GetBy(x => x.Username == userName);
                if (user.Parola == encryptedPassword)
                {
                    return true;
                }
                return false;
            }
        }

        private  string EncryptPassword(string password)
        {
            
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        public void RegisterDonator(string userName, string password, string nume, string prenume, string sex, DateTime dataNastere, string domiciliu, string localitate, string judet, string resedinta, string localitateResedinta, string judetResedinta, string telefon, string email)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Donator donator = new Donator(nume, prenume, sex, dataNastere, domiciliu, localitate, judet, resedinta, localitateResedinta, judetResedinta, telefon, email);
                unitOfWork.DonatorRepo.Save(donator);
                string encryptedPassword= EncryptPassword(password);
                UserDonator user = new UserDonator(userName, encryptedPassword);
                unitOfWork.UserDonatorRepo.Save(user);
                unitOfWork.Save();
                donator = unitOfWork.DonatorRepo.GetBy(d => d.Email.Equals(email));
                user = unitOfWork.UserDonatorRepo.GetBy(u => u.Username.Equals(userName));
                donator.UserDonator = user;
                user.Donator = donator;
                unitOfWork.Save();

            }
        }

        public List<Donator> GetDonatoriByJudet(string judet)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Donator> donatori = new List<Donator>();
                //Donator donator = unitOfWork.DonatorRepo.GetBy(dr => dr.JudetResedinta.Equals(judetResedinta));
                unitOfWork.DonatorRepo.GetAll().Where(d => d.Judet.Equals(judet)).ToList().ForEach(dn => { donatori.Add(dn); });
                return donatori;

            }


        }

        public void UpdateDonator(Donator donator)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.DonatorRepo.Update(donator);
                unitOfWork.Save();
            }
        }

    }
}
