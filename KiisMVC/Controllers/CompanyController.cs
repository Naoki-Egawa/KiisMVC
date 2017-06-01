using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KiisMVC.Models;

namespace KiisMVC.Controllers
{
    public class CompanyController : Controller
    {
        private KiisDbContext db = new KiisDbContext();

        // GET: Company
        public ActionResult Index()
        {
            return View(db.T_CompanyMaster.ToList());
        }

        // GET: Company/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_CompanyMaster t_CompanyMaster = db.T_CompanyMaster.Find(id);
            if (t_CompanyMaster == null)
            {
                return HttpNotFound();
            }
            return View(t_CompanyMaster);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ShearchQuery([Bind(Include = "記号,事業所名")] T_CompanyMaster args)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    int outKigou = 0;

                    IQueryable<T_CompanyMaster> q = null;

                    if (!string.IsNullOrEmpty(args.記号) & !string.IsNullOrEmpty(args.事業所名))
                    {
                       

                        q = db.T_CompanyMaster.Where(x => x.記号 == args.記号).Where(x => x.事業所名.Contains(args.事業所名));


                    }
                    else if (!string.IsNullOrEmpty(args.記号))
                    {

                        q = db.T_CompanyMaster.Where(x => x.記号 == args.記号);

                    }
                    else if (!string.IsNullOrEmpty(args.事業所名))
                    {
                        q = db.T_CompanyMaster.Where(x => x.事業所名.Contains(args.事業所名));

                    }

                    return View(q);


                }

                else
                {
                    var q = db.T_CompanyMaster;
                    return View(q);
                }
            }
            catch (InvalidOperationException ex)
            {
                
                throw;
            }
        }
        // POST: Company/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "記号,社保記号,番号,事業所名,事業主,郵便番号,住所01,住所02,電話番号,被保険者数_男,被保険者数_女,被保険者数計,T_00_事業所登録台帳_付加情報_記号")] T_CompanyMaster t_CompanyMaster)
        {
            if (ModelState.IsValid)
            {
                db.T_CompanyMaster.Add(t_CompanyMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(t_CompanyMaster);
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_CompanyMaster t_CompanyMaster = db.T_CompanyMaster.Find(id);
            if (t_CompanyMaster == null)
            {
                return HttpNotFound();
            }
            return View(t_CompanyMaster);
        }

        // POST: Company/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "記号,社保記号,番号,事業所名,事業主,郵便番号,住所01,住所02,電話番号,被保険者数_男,被保険者数_女,被保険者数計,T_00_事業所登録台帳_付加情報_記号")] T_CompanyMaster t_CompanyMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_CompanyMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t_CompanyMaster);
        }

        // GET: Company/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_CompanyMaster t_CompanyMaster = db.T_CompanyMaster.Find(id);
            if (t_CompanyMaster == null)
            {
                return HttpNotFound();
            }
            return View(t_CompanyMaster);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_CompanyMaster t_CompanyMaster = db.T_CompanyMaster.Find(id);
            db.T_CompanyMaster.Remove(t_CompanyMaster);
            db.SaveChanges();
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
