using Library.Entities;
using MediatR;
using Session3.MediatR.Command;
using Session3.Services;

namespace Session3.MediatR.Handler
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Emplyee>
    {

        readonly IEmployeeServices _employeeService;

        public AddEmployeeHandler(IEmployeeServices employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<Emplyee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeService.AddEmployee(request.employee);
        }
    }
}
