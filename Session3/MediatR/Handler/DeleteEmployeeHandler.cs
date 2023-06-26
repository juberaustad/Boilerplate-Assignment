using Library.Entities;
using MediatR;
using Session3.MediatR.Command;
using Session3.Services;

namespace Session3.MediatR.Handler
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, Emplyee>
    {
        readonly IEmployeeServices _employeeService;
        public DeleteEmployeeHandler(IEmployeeServices employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<Emplyee> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeService.Delete(request.Employee);
        }
    }
}
