using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using MedicalManagement.Domain.Entities;
using MedicalManagement.infra.Data.ORM.EF;

namespace UI.Medical.Controllers
{
    public class BairroController : Controller
    {
        private MMDbContext db = new MMDbContext();

        // GET: Bairroes
        public async Task<ActionResult> Index()
        {
            var bairro = db.Bairro.Include(b => b.Cidade);
            return View(await bairro.ToListAsync());
        }

        // GET: Bairroes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bairro bairro = await db.Bairro.FindAsync(id);
            if (bairro == null)
            {
                return HttpNotFound();
            }
            return View(bairro);
        }

        // GET: Bairroes/Create
        public ActionResult Create()
        {
            ViewBag.CidadeId = new SelectList(db.Cidade, "CidadeId", "Descricao");
            return View();
        }

        // POST: Bairroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BairroId,Descricao,CidadeId")] Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                db.Bairro.Add(bairro);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CidadeId = new SelectList(db.Cidade, "CidadeId", "Descricao", bairro.CidadeId);
            return View(bairro);
        }

        // GET: Bairroes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bairro bairro = await db.Bairro.FindAsync(id);
            if (bairro == null)
            {
                return HttpNotFound();
            }
            ViewBag.CidadeId = new SelectList(db.Cidade, "CidadeId", "Descricao", bairro.CidadeId);
            return View(bairro);
        }

        // POST: Bairroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BairroId,Descricao,CidadeId")] Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bairro).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CidadeId = new SelectList(db.Cidade, "CidadeId", "Descricao", bairro.CidadeId);
            return View(bairro);
        }

        // GET: Bairroes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bairro bairro = await db.Bairro.FindAsync(id);
            if (bairro == null)
            {
                return HttpNotFound();
            }
            return View(bairro);
        }

        // POST: Bairroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Bairro bairro = await db.Bairro.FindAsync(id);
            db.Bairro.Remove(bairro);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
