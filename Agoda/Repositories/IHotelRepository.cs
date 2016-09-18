using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agoda.Models;

namespace Agoda.Repositories
{
    public interface IHotelRepository
    {
        List<Hotel> fetchHotels();
    }
}
