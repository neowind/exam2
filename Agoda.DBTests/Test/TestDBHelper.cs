using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Agoda.Models;

namespace Agoda.DBTests
{
    public class TestDBHelper
    {
        private DBHelper dbHelper;
        private List<Hotel> hotels;

        private Hotel createHotel(int id, string name, double rating, double lowestPrice, string location)
        {
            Hotel hotel = new Hotel();
            hotel.ID = id;
            hotel.Name = name;
            hotel.Rating = rating;
            hotel.LowestPrice = lowestPrice;
            hotel.Location = location;

            return hotel;
        }

        [SetUp]
        public void Setup()
        {
            dbHelper = new DBHelper();
            hotels = new List<Hotel>();

            dbHelper.CreateDB();
            hotels.Add(createHotel(1, "Hotel1", 8, 1000, "BKK"));
            hotels.Add(createHotel(1, "Hotel2", 7.5, 1200, "BKK"));
        }

        [TearDown]
        public void TearDown()
        {
            dbHelper.Delete();
        }

        [Test]
        public void getHotels()
        {
            dbHelper.Add(hotels);
            List<Hotel> dbList = dbHelper.Hotels.ToList();
            Assert.AreEqual(hotels.Count, dbList.Count, "number of data miss match");

            for (int i = 0; i < hotels.Count; i++)
            {
                Assert.That(hotels[i].ID == dbList[i].ID);
                Assert.That(hotels[i].Name == dbList[i].Name);
                Assert.That(hotels[i].Rating == dbList[i].Rating);
                Assert.That(hotels[i].LowestPrice == dbList[i].LowestPrice);
                Assert.That(hotels[i].Location == dbList[i].Location);
            }
        }

        [Test]
        public void removeByID()
        {
            dbHelper.Add(hotels);
            dbHelper.RomoveByID(1);

            List<Hotel> dbList = dbHelper.Hotels.ToList();
            Assert.That(hotels.Count > dbList.Count);
        }
    }
}