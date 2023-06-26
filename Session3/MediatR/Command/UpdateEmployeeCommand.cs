using Library.Entities;
using MediatR;

namespace Session3.MediatR.Command
{
    public class UpdateEmployeeCommand : IRequest<Emplyee>
    {
        public UpdateEmployeeCommand(Emplyee emp)
        {
            emplyee = emp;
        }

        public Emplyee emplyee { get; }
    }
}
