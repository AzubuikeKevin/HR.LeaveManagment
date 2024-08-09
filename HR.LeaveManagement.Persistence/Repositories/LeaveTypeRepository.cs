using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericReposistory<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagementDbContext _dbContext;
        public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
