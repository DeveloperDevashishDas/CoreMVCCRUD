using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreMVCCRUD.Models;
using CoreMVCCRUD.Repository;

namespace CoreMVCCRUD.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private EmployeeContext _context;
        private DbSet<T> table;

        public GenericRepository(EmployeeContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }


        public List<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object Id)
        {
            return table.Find(Id);
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
