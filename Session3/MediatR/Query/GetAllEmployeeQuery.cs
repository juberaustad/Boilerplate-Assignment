using Library.Entities;
using MediatR;

namespace Session3.MediatR.Query
{
    public class GetAllEmployeeQuery : IRequest<List<Emplyee>>
    {
    }
}
