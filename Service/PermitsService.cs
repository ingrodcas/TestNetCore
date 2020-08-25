using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPermitsService
    {
        bool Create(Permits model);
        List<Permits> Index();
        bool Edit(Permits model);
        Permits Details(int? id);
        bool Delete(Permits model);
        List<PermissionType> GetPermissionType();


    }

    public class PermitsService : IPermitsService
    {
        private readonly TestDbContext _context;
        public PermitsService(TestDbContext context)
        {
            _context = context;
        }

        public bool Create(Permits model)
        {
            try
            {
                _context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }
        public bool Edit(Permits model)
        {
            try
            {
                _context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }
        public bool Delete(Permits model)
        {
            try
            {
                _context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }
        public List<Permits> Index()
        {
            var model = _context.Permit.Select(e => e).ToList();
            return model;
        }
        public Permits Details(int? id)
        {
            Permits model = new Permits();
            model = _context.Permit.Where(a => a.Id == id).Select(b => b).FirstOrDefault();
            return model;
        }

        public List<PermissionType> GetPermissionType()
        {
            var model = _context.PermissionType.Select(e => e).ToList();
            return model;
        }

    }
}
