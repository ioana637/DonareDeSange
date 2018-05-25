using CentruDeTransfuzie.model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CerereService
    {
        public void UpdateStoc(Stoc stoc)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.StocRepo.Update(stoc);
                unitOfWork.Save();
            }
        }

        public void AddNotificare(int id_cerere, int id_pacient)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Notificari notificare = new Notificari(id_cerere, id_pacient);
                unitOfWork.NotificariRepo.Save(notificare);
                unitOfWork.Save();
            }
        }

        public List<Notificari> GetNotificari()
        {

            List<Notificari> not = new List<Notificari>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach(var i in unitOfWork.NotificariRepo.GetAll())
                {
                    not.Add(i);
                }
            }

            return not;
        }

        public void DeleteNotificare(int idDonator)
        {
            CerereService service = new CerereService();
            
            var notificari = service.GetNotificari();
            foreach (var i in notificari)
            {
                if (i.id_donator == idDonator)
                {
                    using (UnitOfWork unitOfWork = new UnitOfWork())
                    {
                        unitOfWork.NotificariRepo.Delete(i);
                        unitOfWork.Save();
                    }
                }
            }
        }

    }
}
