using Library.Entities;
using MediatR;

namespace Session3.MediatR.Query
{
    public class GetSingleEmployeeQuery : IRequest<Emplyee>
    {
        public int Id { get; set; }
        public GetSingleEmployeeQuery(int id)
        {
            Id = id;
        }

    }
}
