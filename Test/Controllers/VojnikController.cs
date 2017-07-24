using Prodavnica;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class VojnikController : ApiController
    {
        
        // GET api/vojnik
        public IEnumerable<Vojnik> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Vojnik> vojnici = provider.GetVojnici();

            //return new [] {
            //    new Vojnik() {Naziv="test"}
            //};

            return vojnici;
        }

        // GET api/vojnik/5
        public Vojnik Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetVojnik(id);
        }

        // POST api/vojnik
        public int Post([FromBody]Vojnik v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddVojnik(v);
        }

        // PUT api/vojnik/5
        public void Put(int id, [FromBody]Vojnik v)
        {
        }

        // DELETE api/vojnik/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveVojnik(id);
        }

    }
}
