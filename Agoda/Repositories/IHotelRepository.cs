using System;
using System.Collections.Generic;
using Agoda.Models;

namespace Agoda.Repositories
{
    public interface IHotelRepository
    {
        List<Hotel> fetchHotels();
    }
}
