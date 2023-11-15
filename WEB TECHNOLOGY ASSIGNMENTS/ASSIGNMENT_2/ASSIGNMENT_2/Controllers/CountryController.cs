using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASSIGNMENT_2.Models;

namespace ASSIGNMENT_2.Controllers
{
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>();
        //   {
        //      new Country { ID = 1, CountryName = "India", Capital = "Delhi" },
        //      new Country { ID = 2, CountryName = "America", Capital = "New york" },
        //      new Country { ID = 3, CountryName = "japan", Capital = "tokyo" }
        //    }


        // GET api/Country
public IHttpActionResult GetCountries()
        {
            return Ok(countries);
        }

        // GET api/Country/1
        public IHttpActionResult GetCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.id == id);
            if (country == null)
                return NotFound();

            return Ok(country);
        }

        // POST api/Country
        public IHttpActionResult PostCountry(Country country)
        {
            country.id = countries.Count + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.id }, country);
        }

        // PUT api/Country/1
        public IHttpActionResult PutCountry(int id, Country country)
        {
            var existingCountry = countries.FirstOrDefault(c => c.id == id);
            if (existingCountry == null)
                return NotFound();

            existingCountry.CountryName = country.CountryName;
            existingCountry.Capital = country.Capital;

            return Ok(existingCountry);
        }

        // DELETE api/Country/1
        public IHttpActionResult DeleteCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.id == id);
            if (country == null)
                return NotFound();

            countries.Remove(country);
            return Ok(country);
        }
    }
}