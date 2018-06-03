using CentruDeTransfuzie.model;
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
                string encryptedPassword = Util.EncryptPassword(password);



                UserDonator user = unitOfWork.UserDonatorRepo.GetBy(x => x.Username.Equals(userName));
                if (user.Parola.Equals(encryptedPassword))
                {
                    return true;
                }
                return false;
            }
        }



        public Donator GetDonator(string username)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                //!!!Se arunca exceptie la logare desi userul exista in bd. Donatorul returnat de functie este null!!!!!!
                Donator donator = unitOfWork.DonatorRepo.GetBy(x => x.UserDonator.Username.Equals(username));
                if (donator.Equals(null)) { throw new ValidationException(); }
                return donator;
            }
        }

        public string Encrypt(string pass)
        {
            return Util.EncryptPassword(pass);
        }

        public void RegisterDonator(string userName, string password, string nume, string prenume, string sex, DateTime dataNastere, string domiciliu, string localitate, string judet, string resedinta, string localitateResedinta, string judetResedinta, string telefon, string email)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                
                Donator donator = new Donator(nume, prenume, sex, dataNastere, domiciliu, localitate, judet, resedinta, localitateResedinta, judetResedinta, telefon, email);
                unitOfWork.DonatorRepo.Save(donator);
                string encryptedPassword = Util.EncryptPassword(password);
                UserDonator user = new UserDonator(userName, encryptedPassword);
                unitOfWork.UserDonatorRepo.Save(user);
                unitOfWork.Save();
                donator = unitOfWork.DonatorRepo.GetBy(d => d.Email.Equals(email));
                user = unitOfWork.UserDonatorRepo.GetBy(u => u.Username.Equals(userName));
                donator.UserDonator = user;
                user.Donator = donator;
                unitOfWork.Save();
                
                /*
                Donator donator = new Donator(nume, prenume, sex, dataNastere, domiciliu, localitate, judet, resedinta, localitateResedinta, judetResedinta, telefon, email);
                string encryptedPassword = Util.EncryptPassword(password);
                UserDonator user = new UserDonator(userName, encryptedPassword);
                donator.UserDonator = user;
                user.Donator = donator;
                unitOfWork.UserDonatorRepo.Save(user);
                unitOfWork.DonatorRepo.Save(donator);
                unitOfWork.Save();
                */
            }
        }

        public void DeleteDonatorAndUser(Donator donator, UserDonator userDonator)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.UserDonatorRepo.Delete(userDonator);
                unitOfWork.DonatorRepo.Delete(donator);
                unitOfWork.Save();
            }
        }

        public List<Donator> GetAllDonatori()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Donator> donatori = new List<Donator>();
                unitOfWork.DonatorRepo.GetAll().ToList().ForEach(dn => { donatori.Add(dn); });
                return donatori;
            }
        }

        public List<Donator> GetDonatoriByNume(String nume)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Donator> donatori = new List<Donator>();
                unitOfWork.DonatorRepo.GetAll().Where(d => d.Nume.Equals(nume)).ToList().ForEach(don => { donatori.Add(don); });
                return donatori;
            }
        }

        public List<Donator> GetDonatoriByDataNasterii(String dataNasterii)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Donator> donatori = new List<Donator>();
                unitOfWork.DonatorRepo.GetAll().Where(d => d.DataNastere.Equals(DateTime.Parse(dataNasterii))).ToList().ForEach(don => { donatori.Add(don); });
                return donatori;
            }
        }

        public List<Donator> GetDonatoriByJudet(String judet)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Donator> donatori = new List<Donator>();
                unitOfWork.DonatorRepo.GetAll().Where(d => d.Judet.Equals(judet)).ToList().ForEach(don => { donatori.Add(don); });
                return donatori;
            }
        }

        public List<Donator> GetDonatoriByActivitate(String activ)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Donator> donatori = new List<Donator>();
                unitOfWork.DonatorRepo.GetAll().Where(d => d.Activ.Equals(activ)).ToList().ForEach(don => { donatori.Add(don); });
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

        public void UpdateUserDonator(UserDonator user)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.UserDonatorRepo.Update(user);
                unitOfWork.Save();
            }
        }

        public static bool NeedsToBeNotified(int idDon)
        {
            CerereService service = new CerereService();

            foreach (var i in service.GetNotificari())
            {
                if (i.id_donator == idDon)
                {
                    //de ce delete?
                    //ca sa nu fie notificat de mai multe ori :)
                    //service.DeleteNotificare(idDon);
                    return true;
                }
            }
            return false;
        }


        public List<Cerere> GetAllCereriByIdDonator(string username)
        {
            List<int> idCereri = new List<int>();
            List<Cerere> cereri = new List<Cerere>();
            UserDonator user;
            Donator donator;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                user=unitOfWork.UserDonatorRepo.GetBy(u => u.Username.Equals(username));
                donator=unitOfWork.DonatorRepo.GetBy(d => d.UserDonator.Equals(user));
                unitOfWork.NotificariRepo.GetAll().Where(n => n.id_donator.Equals(donator.Id)).ToList().ForEach(n => { idCereri.Add(n.id_cerere); });
                idCereri.ForEach(id => cereri.Add(unitOfWork.CerereRepo.GetBy(x => x.Id.Equals(id))));
                unitOfWork.Save();
            }
            return cereri;
        }

        public List<Analiza> GetAllAnalizeByIdDonator(string username)
        {
            List<int> idAnalize = new List<int>();
            List<Analiza> analize = new List<Analiza>();
            UserDonator user;
            Donator donator;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                user = unitOfWork.UserDonatorRepo.GetBy(u => u.Username.Equals(username));
                donator = unitOfWork.DonatorRepo.GetBy(d => d.UserDonator.Equals(user));
                unitOfWork.NotificariRepo.GetAll().Where(n => n.id_donator.Equals(donator.Id)).ToList().ForEach(n => { idAnalize.Add(n.id_cerere); });
                idAnalize.ForEach(id => analize.Add(unitOfWork.AnalizaRepo.GetBy(x => x.Id.Equals(id))));
                unitOfWork.Save();
            }

            return analize;
        }
    }
}
