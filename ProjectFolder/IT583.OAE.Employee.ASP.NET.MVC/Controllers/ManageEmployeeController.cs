using IT583.OAE.Employee.BLDAL.BusinessLogicLayer;
using IT583.OAE.Employee.BLDAL.BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IT583.OAE.Employee.ASP.NET.MVC.Controllers
{
    public class ManageEmployeeController : Controller
    {
        // GET: ManageEmployee
        public ActionResult Index()
        {
            List<Employees> employeeList = EmployeeBLL.Employee_SelectList();
            return View(employeeList);
        }

        // GET: ManageEmployee/Details/5
        public ActionResult Details(int? id)
        {
            Employees model = EmployeeBLL.Employee_Select(new Employees { EmployeeID = id });
            return View(model);
        }

        // GET: ManageEmployee/Create
        public ActionResult Create()
        {
            return View(new Employees());
        }

        // POST: ManageEmployee/Create
        [HttpPost]
        public ActionResult Create(Employees model)
        {
            try
            {
                if (EmployeeBLL.Employee_Insert(model))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ManageEmployee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employee = EmployeeBLL.Employee_Select(new Employees { EmployeeID = id });
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: ManageEmployee/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, Employees employee)
        {
            if (ModelState.IsValid)
            {
                if (EmployeeBLL.Employee_Update(employee))
                {
                    return RedirectToAction("Index");

                }
                else
                {
                    return View(employee);
                }

            }
            else
            {
                return View(employee); ;
            }
        }

        // GET: ManageEmployee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employee = EmployeeBLL.Employee_Select(new Employees { EmployeeID = id });
            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        // POST: ManageEmployee/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Employees employee)
        {
            try
            {
                if (EmployeeBLL.Employee_Delete(new Employees { EmployeeID = id }))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(employee);
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
