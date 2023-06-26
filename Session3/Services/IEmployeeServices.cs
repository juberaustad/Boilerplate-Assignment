using Library.Entities;
using Library.Context;
namespace Session3.Services
{
    public interface IEmployeeServices
    {
        public List<Emplyee> GetAll();
        public Emplyee GetById(int id);
        public Task<Emplyee> AddEmployee(Emplyee employee);

        public Task<Emplyee> Edit(Emplyee employee);
        public Task<Emplyee> Delete(Emplyee employee);
    }
}
