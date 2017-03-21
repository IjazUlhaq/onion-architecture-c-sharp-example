using OnionArch.Infrastructure;
using OnionArch.Infrastructure.Repository;
using OnionArchERP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ERPContext DbContext { get; }

        GenericRepository<HC_Employee> EmployeeRepository { get; }
        GenericRepository<HC_EmployeeJoining> JoiningRepository { get; }
        GenericRepository<HC_Attendance> AttendanceRepository { get; }
        GenericRepository<HC_EmployeeContactNumber> ContactNoRepository { get; }
        GenericRepository<HC_EmployeeEmailAddress> EmailAddressRepository { get; }
        GenericRepository<SYS_Department> DepartmentRepository { get; }
        GenericRepository<HC_Designation> DesignationRepository { get; }
        void Save();
    }
}
