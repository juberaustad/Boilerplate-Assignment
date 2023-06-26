using Library.Entities;
using MediatR;

namespace Session3.MediatR.Command
{
    public class AddEmployeeCommand : IRequest<Emplyee>
    {
        public Emplyee employee { get; }
        public AddEmployeeCommand(Emplyee emp)
        {
            employee = emp;
        }
    }
}
