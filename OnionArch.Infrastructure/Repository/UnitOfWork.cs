using OnionArch.Infrastructure.Repository;
using OnionArchERP.Core.Entities;
using OnionArchERP.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;

        private ERPContext context;

        private GenericRepository<HC_Employee> _employeeRepository;
        private GenericRepository<HC_EmployeeJoining> _joiningRepository;
        private GenericRepository<HC_Attendance> _attendanceRepository;
        private GenericRepository<HC_EmployeeContactNumber> _contactNoRepository;
        private GenericRepository<HC_EmployeeEmailAddress> _emailAddressRepository;
        private GenericRepository<SYS_Department> _departmentRepository;
        private GenericRepository<HC_Designation> _designationRepository;

        public ERPContext DbContext
        {
            get
            {
                if (context == null)
                {
                    context = new ERPContext();
                }
                return context;
            }
        }

        public GenericRepository<HC_Employee> EmployeeRepository
        {
            get
            {

                if (this._employeeRepository == null)
                {
                    this._employeeRepository = new GenericRepository<HC_Employee>(DbContext);
                }
                return _employeeRepository;
            }
        }

        public GenericRepository<HC_EmployeeJoining> JoiningRepository
        {
            get
            {

                if (this._joiningRepository == null)
                {
                    this._joiningRepository = new GenericRepository<HC_EmployeeJoining>(DbContext);
                }
                return _joiningRepository;
            }
        }

        public GenericRepository<HC_Attendance> AttendanceRepository
        {
            get
            {

                if (this._attendanceRepository == null)
                {
                    this._attendanceRepository = new GenericRepository<HC_Attendance>(DbContext);
                }
                return _attendanceRepository;
            }
        }

        public GenericRepository<HC_EmployeeContactNumber> ContactNoRepository
        {
            get
            {

                if (this._contactNoRepository == null)
                {
                    this._contactNoRepository = new GenericRepository<HC_EmployeeContactNumber>(DbContext);
                }
                return _contactNoRepository;
            }
        }

        public GenericRepository<HC_EmployeeEmailAddress> EmailAddressRepository
        {
            get
            {

                if (this._emailAddressRepository == null)
                {
                    this._emailAddressRepository = new GenericRepository<HC_EmployeeEmailAddress>(DbContext);
                }
                return _emailAddressRepository;
            }
        }

        public GenericRepository<SYS_Department> DepartmentRepository
        {
            get
            {

                if (this._departmentRepository == null)
                {
                    this._departmentRepository = new GenericRepository<SYS_Department>(DbContext);
                }
                return _departmentRepository;
            }
        }

        public GenericRepository<HC_Designation> DesignationRepository
        {
            get
            {

                if (this._designationRepository == null)
                {
                    this._designationRepository = new GenericRepository<HC_Designation>(DbContext);
                }
                return _designationRepository;
            }
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
