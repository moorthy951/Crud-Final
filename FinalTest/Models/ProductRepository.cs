using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalTest.Models
{
    public class ProductRepository
    {
        MVC_CRUDEntities ProductDB = new MVC_CRUDEntities();
        public IEnumerable<Vehicle> GetAll()
        {
            // TO DO : Code to get the list of all the records in database
            return ProductDB.Vehicles;
        }

        public Vehicle Get(int id)
        {
            // TO DO : Code to find a record in database
            return ProductDB.Vehicles.Find(id);
        }

        public Vehicle Add(Vehicle item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to save record into database
            ProductDB.Vehicles.Add(item);
            ProductDB.SaveChanges();
            return item;
        }

        public bool Update(Vehicle item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to update record into database
            var products = ProductDB.Vehicles.Single(a => a.Vin == item.Vin);
            products.Name = item.Name;
            products.Date_of_release = item.Date_of_release;

            ProductDB.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            // TO DO : Code to remove the records from database
            Vehicle products = ProductDB.Vehicles.Find(id);
            ProductDB.Vehicles.Remove(products);
            ProductDB.SaveChanges();
            return true;
        }
    
    }
}