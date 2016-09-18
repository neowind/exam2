using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using Agoda.Models;

namespace Agoda.Controllers
{
    public class DefaultController : Controller
    {

        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Static()
        {
            var hotelRepository = new HotelRepository();
            var hotelList = hotelRepository.fetchHotels();
            return View(hotelList);
        }

        public ActionResult Ajax()
        {
            return View();
        }
    }
}
