using HRManagement.Core.DataAccess.EntityFramework;
using HRManagement.DAL.Abstract;
using HRManagement.DAL.Concrete.Context;
using HRManagement.Model.Entities;

namespace HRManagement.DAL.Concrete.Repository
{
    class EmployeeRepository : EFRepositoryBase<Employee, HRManagementDbContext>, IEmployeeDAL
    {
        public EmployeeRepository(HRManagementDbContext context) : base(context)
        {

        }
    }
}
