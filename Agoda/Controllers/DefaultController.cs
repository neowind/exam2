using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Agoda.Repositories;

namespace Agoda.Controllers
{
    public class DefaultController : Controller
    {
        private IHotelRepository hotelRepository;
 
        public DefaultController(IHotelRepository hotelRepositoryInput)
        {
            hotelRepository = hotelRepositoryInput;
        }

        public ActionResult Static()
        {
            var hotelList = hotelRepository.fetchHotels();
            return View(hotelList);
        }

        public ActionResult Ajax()
        {
            return View();
        }
    }
}
