using Library.Entities;
using MediatR;
using Session3.MediatR.Query;
using Session3.Services;

namespace Session3.MediatR.Handler
{
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, List<Emplyee>>
    {
        readonly IEmployeeServices _employeeService;
        public GetAllEmployeeHandler(IEmployeeServices employeeService)
        {
            this._employeeService = employeeService;
        }
        public Task<List<Emplyee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => {
                return _employeeService.GetAll();
            });
        }
    }
}
