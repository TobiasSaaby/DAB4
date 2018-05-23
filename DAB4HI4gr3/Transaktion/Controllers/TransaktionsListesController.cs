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

namespace Transaktion.Controllers
{
    public class TransaktionsListesController : ApiController
    {
        private DBContext db = new DBContext();

        // GET: api/TransaktionsListes
        public IQueryable<TransaktionsListe> GetTransaktionsLister()
        {
            return db.TransaktionsLister;
        }

        // GET: api/TransaktionsListes/5
        [ResponseType(typeof(TransaktionsListe))]
        public IHttpActionResult GetTransaktionsListe(int id)
        {
            TransaktionsListe transaktionsListe = db.TransaktionsLister.Find(id);
            if (transaktionsListe == null)
            {
                return NotFound();
            }

            return Ok(transaktionsListe);
        }

        // PUT: api/TransaktionsListes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTransaktionsListe(int id, TransaktionsListe transaktionsListe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transaktionsListe.Id)
            {
                return BadRequest();
            }

            db.Entry(transaktionsListe).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransaktionsListeExists(id))
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

        // POST: api/TransaktionsListes
        [ResponseType(typeof(TransaktionsListe))]
        public IHttpActionResult PostTransaktionsListe(TransaktionsListe transaktionsListe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TransaktionsLister.Add(transaktionsListe);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = transaktionsListe.Id }, transaktionsListe);
        }

        // DELETE: api/TransaktionsListes/5
        [ResponseType(typeof(TransaktionsListe))]
        public IHttpActionResult DeleteTransaktionsListe(int id)
        {
            TransaktionsListe transaktionsListe = db.TransaktionsLister.Find(id);
            if (transaktionsListe == null)
            {
                return NotFound();
            }

            db.TransaktionsLister.Remove(transaktionsListe);
            db.SaveChanges();

            return Ok(transaktionsListe);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TransaktionsListeExists(int id)
        {
            return db.TransaktionsLister.Count(e => e.Id == id) > 0;
        }
    }
}