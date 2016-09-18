using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.Entity;
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

        // GET api/ajax
        [Route("api/ajax")]
        public IEnumerable<Hotel> Get()
        {
            var hotelList = hotelRepository.fetchHotels();
            return hotelList;
            //return db.Hotels.ToList();
        }

        //// GET api/ajax/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/ajax
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/ajax/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/ajax/5
        //public void Delete(int id)
        //{
        //}
    }
}
