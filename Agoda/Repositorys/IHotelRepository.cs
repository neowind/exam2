using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agoda.Models
{
    public interface IHotelRepository
    {
        List<Hotel> fetchHotels();
    }

    public class HotelRepository : IHotelRepository
    {
        private HotelDBContext db = new HotelDBContext();

        public List<Hotel> fetchHotels()
        {
            return db.Hotels.ToList();
        }
    }
}
