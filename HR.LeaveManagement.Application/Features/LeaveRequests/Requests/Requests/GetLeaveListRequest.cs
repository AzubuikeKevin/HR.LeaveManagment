using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Requests
{
    public class GetLeaveListRequest : IRequest<List<LeaveRequestListDto>>
    {
    }
}
