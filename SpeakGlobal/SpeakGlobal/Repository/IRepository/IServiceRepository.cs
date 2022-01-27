using SpeakGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakGlobal.Repository.IRepository
{
    public interface IServiceRepository
    {
        List<Service> GetAll();
        Service Get(int id);
        bool Create(Service service);
        bool Update(Service service);
        bool Delete(int id);
    }
}
