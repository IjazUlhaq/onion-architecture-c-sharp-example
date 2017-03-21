using System.Linq;
using System.Net;
using System.Web.Mvc;
using OnionArchERP.Models;
using AutoMapper;
using OnionArchERP.Core.Entities;
using OnionArchERP.Infrastructure.Interfaces;
using OnionArch.Infrastructure.Repository;


namespace OnionArchERP.Controllers
{
    public class EmployeesController : Controller
    {
        private IUnitOfWork unitOfWork;

        // Dependancey Injection(Parameterise constructor)
        public EmployeesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Employees
        public ActionResult Index()
        {
            var employees = unitOfWork.EmployeeRepository.Get();
            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HC_Employee employee = unitOfWork.EmployeeRepository.GetByID(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Code,FirstName,MiddleName,LastName,RelationId,GuardianFirstName,GuardianMiddleName,GuardianLastName,Gender,DateOfBirth,MaritalStatus,NationalIdNo,PasportNo,Image,BloodGroupId,ReligionId,Status,CarearStartDate")] EmployeeVM employeeVM)
        {
            if (ModelState.IsValid)
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<EmployeeVM, HC_Employee>();
                });
                var employee = Mapper.Map<EmployeeVM,HC_Employee>(employeeVM);
                unitOfWork.EmployeeRepository.Insert(employee);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }

            //ViewBag.BranchId = new SelectList(db.Branches, "ID", "BranchCode", employee.BranchId);
            return View(employeeVM);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HC_Employee employee = unitOfWork.EmployeeRepository.GetByID(id);
            Mapper.CreateMap<HC_Employee, EmployeeVM>();
            var employeeVM = Mapper.Map<HC_Employee, EmployeeVM>(employee);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employeeVM);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Code,FirstName,MiddleName,LastName,RelationId,GuardianFirstName,GuardianMiddleName,GuardianLastName,Gender,DateOfBirth,MaritalStatus,NationalIdNo,PasportNo,Image,BloodGroupId,ReligionId,Status,CarearStartDate")] EmployeeVM employeeVM)
        {
            if (ModelState.IsValid)
            {

                Mapper.CreateMap<EmployeeVM, HC_Employee>();
                var employee = Mapper.Map<EmployeeVM, HC_Employee>(employeeVM);

                unitOfWork.EmployeeRepository.Update(employee);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(employeeVM);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HC_Employee employee = unitOfWork.EmployeeRepository.GetByID(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HC_Employee employee = unitOfWork.EmployeeRepository.GetByID(id);
            unitOfWork.EmployeeRepository.Delete(employee);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }


    }
}
