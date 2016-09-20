using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Agoda.Repositories;
using Agoda.Models;

namespace Agoda.Controllers
{
    [RoutePrefix("Default")]
    public class AjaxController : ApiController
    {
        private IHotelRepository hotelRepository;

        public AjaxController(IHotelRepository hotelRepositoryInput)
        {
            hotelRepository = hotelRepositoryInput;
        }

        // GET defalut/api/ajax
        [Route("api/ajax")]
        public IEnumerable<Hotel> Get()
        {
            var hotelList = hotelRepository.fetchHotels();
            return hotelList;
        }
    }
}
