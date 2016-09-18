using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
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

        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View();
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
