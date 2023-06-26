using Library.Entities;
using MediatR;
using Session3.MediatR.Query;
using Session3.Services;

namespace Session3.MediatR.Handler
{
    public class GetSingleEmployeeHandler : IRequestHandler<GetSingleEmployeeQuery, Emplyee>
    {

        readonly IEmployeeServices _employeeService;
        public GetSingleEmployeeHandler(IEmployeeServices employeeService)
        {
            _employeeService = employeeService;

        }
        public Task<Emplyee> Handle(GetSingleEmployeeQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => {
                return _employeeService.GetById(request.Id);
            });
        }
    }
}
