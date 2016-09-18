using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agoda.Models;

namespace Agoda.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private HotelDBContext db = new HotelDBContext();

        public List<Hotel> fetchHotels()
        {
            return db.Hotels.ToList();
        }
    }
}