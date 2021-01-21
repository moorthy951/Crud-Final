using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalTest.Models
{
    public interface IProductRepository
    {
        IEnumerable<Vehicle> GetAll();
        Vehicle Get(int id);
        Vehicle Add(Vehicle item);
        bool Update(Vehicle item);
        bool Delete(int id);
    }
}