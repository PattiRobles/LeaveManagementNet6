using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        //constructo that injects the DBContext. Base is this case is the GenericRepository class, where you are inheriting from
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
