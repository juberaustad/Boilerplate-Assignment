using Library.Entities;
using MediatR;
using Session3.MediatR.Command;
using Session3.Services;

namespace Session3.MediatR.Handler
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, Emplyee>
    {
        readonly IEmployeeServices _employeeService;

        public UpdateEmployeeHandler(IEmployeeServices employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<Emplyee> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeService.Edit(request.emplyee);
        }
    }
}
