using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationsDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }   
    }
}
