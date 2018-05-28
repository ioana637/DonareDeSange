using CentruDeTransfuzie.model;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AdminService
    {
        public int Login(String username, String password)
        {
            Admin admin = GetAdminByUsername(username);
            if (admin == null) return -1;
            if (admin.Parola.Equals(Util.EncryptPassword(password)))
                return admin.Id;
            else return -1;
        }

        public Admin GetAdminByUsername(string username)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {

                Admin admin = unitOfWork.AdminRepo.GetBy((a) => a.Username.Equals(username));
                return admin;
            }
        }

        public IList<CentruTransfuzie> GetAllCentre()
        {

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                IList<CentruTransfuzie> centre = new List<CentruTransfuzie>();
                unitOfWork.CentruTransfuzieRepo.GetAll().ToList().ForEach(dn => { centre.Add(dn); });
                return centre;
            }
        }

        public List<Spital> GetAllSpitale()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<Spital> spitale = new List<Spital>();
                unitOfWork.SpitalRepo.GetAll().ToList().ForEach(dn => { spitale.Add(dn); });
                return spitale;
            }
        }

        public void AddCentru(CentruTransfuzie centru)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                centru.Parola = Util.EncryptPassword(centru.Parola);
                unitOfWork.CentruTransfuzieRepo.Save(centru);
                unitOfWork.Save();
            }
        }

        public void Delete(CentruTransfuzie centru)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.CentruTransfuzieRepo.Delete(centru);
                unitOfWork.Save();
            }
        }

        public IList<Medic> GetAllMedici()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                IList<Medic> medici = new List<Medic>();
                unitOfWork.MedicRepo.GetAll().ToList().ForEach(md => { medici.Add(md); });
                return medici;
            }
        }

        public void AddSpital(Spital spital, CentruTransfuzie centru)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                CentruTransfuzie centruFromBD = unitOfWork.CentruTransfuzieRepo.GetBy(c => c.Id == centru.Id);
                spital.CentruTransfuzie = centruFromBD;
                unitOfWork.SpitalRepo.Save(spital);
                unitOfWork.Save();
            }
        }

        public void DeleteSpital(Spital spital)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Spital spitalDB = unitOfWork.SpitalRepo.GetBy(m => m.Id.Equals(spital.Id));
                List<SpitalMedic> spitalMedics = unitOfWork.SpitalMedicRepo.GetAll().ToList();
                spitalMedics.ForEach(sm =>
                {
                    if (sm.IdSpital.Equals(spitalDB.Id))
                    {
                        unitOfWork.SpitalMedicRepo.Delete(sm);
                    }
                });
                unitOfWork.SpitalRepo.Delete(spitalDB);
                unitOfWork.Save();
            }
        }

        public void AddMedic(Medic medic, UserMedic userMedic, List<Spital> spitals)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                userMedic.Parola = Util.EncryptPassword(userMedic.Parola);
                medic.UserMedic = userMedic;
                userMedic.Medic = medic;
                unitOfWork.UserMedicRepo.Save(userMedic);
                unitOfWork.MedicRepo.Save(medic);
                unitOfWork.Save();
                Medic medicSalvat = unitOfWork.MedicRepo.GetBy(m => m.Cnp.Equals(medic.Cnp));
                List<Spital> spitaleFromDb = new List<Spital>();
                //spitaleFromDb.Add(unitOfWork.SpitalRepo.GetBy(s => s.Id.Equals(5)));
                spitals.ForEach(s => spitaleFromDb.Add(unitOfWork.SpitalRepo.GetBy(sdb => sdb.Id.Equals(s.Id))));

                spitaleFromDb.ForEach(s =>
                {
                    SpitalMedic sm = new SpitalMedic()
                    {
                        IdMedic = medicSalvat.Id,
                        IdSpital = s.Id,
                        Medic = medicSalvat,
                        Spital = s
                    };
                    if (s.SpitalMedici == null)
                    {
                        s.SpitalMedici = new List<SpitalMedic>();
                    }
                    s.SpitalMedici.Add(sm);
                    if (medicSalvat.SpitaleMedic == null)
                    {
                        medicSalvat.SpitaleMedic = new List<SpitalMedic>();
                    }
                    medicSalvat.SpitaleMedic.Add(sm);
                });
                unitOfWork.Save();
            }
        }

        public void DeleteMedicAndUser(Medic medic, UserMedic user)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Medic medicDB = unitOfWork.MedicRepo.GetBy(m => m.Id.Equals(medic.Id));
                List<SpitalMedic> spitalMedics = unitOfWork.SpitalMedicRepo.GetAll().ToList();
                spitalMedics.ForEach(sm =>
                {
                    if (sm.IdMedic.Equals(medicDB.Id))
                    {
                        unitOfWork.SpitalMedicRepo.Delete(sm);
                    }
                });

                unitOfWork.MedicRepo.Delete(medicDB);
                unitOfWork.UserMedicRepo.Delete(user);
                unitOfWork.Save();
            }
        }

        public UserMedic GetUserMedicByMedic(Medic medic)
        {
            UserMedic user = null;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                user = unitOfWork.UserMedicRepo.GetBy((u) => u.Medic == medic);
                unitOfWork.Save();
            }
            return user;
        }
    }


}

