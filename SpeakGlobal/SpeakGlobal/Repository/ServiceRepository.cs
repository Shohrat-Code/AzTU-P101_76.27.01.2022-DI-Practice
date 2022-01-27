using SpeakGlobal.Data;
using SpeakGlobal.Models;
using SpeakGlobal.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakGlobal.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly AppDbContext _context;

        public ServiceRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Create(Service service)
        {
            _context.Services.Add(service);
            int result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            _context.Services.Remove(_context.Services.Find(id));
            int result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Service Get(int id)
        {
            return _context.Services.Find(id);
        }

        public List<Service> GetAll()
        {
            return _context.Services.ToList();
        }

        public bool Update(Service service)
        {
            _context.Services.Update(service);
            int result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
