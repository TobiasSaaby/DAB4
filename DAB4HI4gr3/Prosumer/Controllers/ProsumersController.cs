using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DAB4.Modeller;
using DAB4.Modeller.Context;

namespace Prosumer.Controllers
{
    public class ProsumersController : ApiController
    {
        private ProsumerContext db = new ProsumerContext();

        // GET: api/Prosumers
        public IQueryable<DAB4.Modeller.Prosumer> GetProsumere()
        {
            return db.Prosumere;
        }

        // GET: api/Prosumers/5
        [ResponseType(typeof(DAB4.Modeller.Prosumer))]
        public IHttpActionResult GetProsumer(int id)
        {
            DAB4.Modeller.Prosumer prosumer = db.Prosumere.Find(id);
            if (prosumer == null)
            {
                return NotFound();
            }

            return Ok(prosumer);
        }

        // PUT: api/Prosumers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProsumer(int id, DAB4.Modeller.Prosumer prosumer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prosumer.Id)
            {
                return BadRequest();
            }

            db.Entry(prosumer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProsumerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Prosumers
        [ResponseType(typeof(DAB4.Modeller.Prosumer))]
        public IHttpActionResult PostProsumer(DAB4.Modeller.Prosumer prosumer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Prosumere.Add(prosumer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = prosumer.Id }, prosumer);
        }

        // DELETE: api/Prosumers/5
        [ResponseType(typeof(DAB4.Modeller.Prosumer))]
        public IHttpActionResult DeleteProsumer(int id)
        {
            DAB4.Modeller.Prosumer prosumer = db.Prosumere.Find(id);
            if (prosumer == null)
            {
                return NotFound();
            }

            db.Prosumere.Remove(prosumer);
            db.SaveChanges();

            return Ok(prosumer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProsumerExists(int id)
        {
            return db.Prosumere.Count(e => e.Id == id) > 0;
        }
    }
}