using CoreMVCCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCCRUD.Repository
{
    public interface IRepository<T> where T: class
    {
        List<T> GetAll();
        T GetById(int Id);


    }
}
