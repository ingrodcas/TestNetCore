using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPermissionTypesService
    {
        bool Create(PermissionType model);
        List<PermissionType> Index();
        bool Edit(PermissionType model);
        PermissionType Details(int? id);
        bool Delete(PermissionType model);


    }


    public class PermissionTypesService : IPermissionTypesService
    {
        private readonly TestDbContext _context;
        public PermissionTypesService(TestDbContext context)
        {
            _context = context;
        }
       
        public bool Create(PermissionType model)
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
        public bool Edit(PermissionType model)
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
        public bool Delete(PermissionType model)
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
        public List<PermissionType> Index()
        {
            var model = _context.PermissionType.Select(e => e).ToList();
            return model;
        }
        public PermissionType Details(int? id)
        {
            PermissionType model = new PermissionType();
            model = _context.PermissionType.Where(a => a.Id == id).Select(b => b).FirstOrDefault();
            return model;
        }
    }
}
