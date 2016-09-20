using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using Agoda.Models;

namespace Agoda.DBTests
{
    public class DBHelper : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public void CreateDB()
        {
            if (this.Database.Exists())
            {
                this.Database.Delete();
            }

            this.Database.Create();
        }

        public void Delete()
        {
            if (this.Database.Exists())
            {
                this.Database.Delete();
            }
        }

        public void Add(List<Hotel> hotels)
        {
            foreach (var hotel in hotels)
            {
                this.Hotels.Add(hotel);
                this.SaveChanges();
            }
        }

        public void RemoveAll()
        {
            foreach (var entity in this.Hotels)
            {
                this.Hotels.Remove(entity);
            }

            this.SaveChanges();
        }

        public void RomoveByID(int ID)
        {
            Hotel hotel = this.Hotels.Find(ID);
            this.Hotels.Remove(hotel);
            this.SaveChanges();
        }
    }
}