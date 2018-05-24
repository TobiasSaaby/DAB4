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

namespace MSGrid.Controllers
{
    public class MiniSmartGridsController : ApiController
    {
        private MSGridContext db = new MSGridContext();

        // GET: api/MiniSmartGrids
        public IQueryable<MiniSmartGrid> GetMiniSmartGridde()
        {
            return db.MiniSmartGridde;
        }

        // GET: api/MiniSmartGrids/5
        [ResponseType(typeof(MiniSmartGrid))]
        public IHttpActionResult GetMiniSmartGrid(int id)
        {
            MiniSmartGrid miniSmartGrid = db.MiniSmartGridde.Find(id);
            if (miniSmartGrid == null)
            {
                return NotFound();
            }

            return Ok(miniSmartGrid);
        }

        // PUT: api/MiniSmartGrids/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMiniSmartGrid(int id, MiniSmartGrid miniSmartGrid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != miniSmartGrid.Id)
            {
                return BadRequest();
            }

            db.Entry(miniSmartGrid).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiniSmartGridExists(id))
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

        // POST: api/MiniSmartGrids
        [ResponseType(typeof(MiniSmartGrid))]
        public IHttpActionResult PostMiniSmartGrid(MiniSmartGrid miniSmartGrid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MiniSmartGridde.Add(miniSmartGrid);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = miniSmartGrid.Id }, miniSmartGrid);
        }

        // DELETE: api/MiniSmartGrids/5
        [ResponseType(typeof(MiniSmartGrid))]
        public IHttpActionResult DeleteMiniSmartGrid(int id)
        {
            MiniSmartGrid miniSmartGrid = db.MiniSmartGridde.Find(id);
            if (miniSmartGrid == null)
            {
                return NotFound();
            }

            db.MiniSmartGridde.Remove(miniSmartGrid);
            db.SaveChanges();

            return Ok(miniSmartGrid);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MiniSmartGridExists(int id)
        {
            return db.MiniSmartGridde.Count(e => e.Id == id) > 0;
        }
    }
}