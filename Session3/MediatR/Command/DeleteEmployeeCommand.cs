using Library.Entities;
using MediatR;

namespace Session3.MediatR.Command
{
    public class DeleteEmployeeCommand : IRequest<Emplyee>
    {
        public Emplyee Employee { get; }
        public DeleteEmployeeCommand(Emplyee emp)
        {
            Employee = emp;
        }
    }
}
