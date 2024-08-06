using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain
{
    public class LeaveType : AuditableEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
