using Library.Entities;
using Library.Context;
namespace Session3.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        readonly EmloyeeDbContext _employeeDbContext;

        public EmployeeServices(EmloyeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public List<Emplyee> GetAll()
        {
            return _employeeDbContext.EmployeeTbl.ToList();
        }

        public Emplyee GetById(int id)
        {
            return _employeeDbContext.EmployeeTbl.Where(X => X.Id == id).FirstOrDefault();
        }


        public async Task<Emplyee> AddEmployee(Emplyee employee)
        {
            _employeeDbContext.EmployeeTbl.Add(employee);
            await _employeeDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Emplyee> Edit(Emplyee employee)
        {
            //Employee emp=  _employeeDbContext.EmployeeTbl.Where(X => X.Id == employee.Id).FirstOrDefault();
            // if(emp != null)
            // {

            _employeeDbContext.EmployeeTbl.Update(employee);
            await _employeeDbContext.SaveChangesAsync();
            return employee;

            //}
            //else
            //{
            //    throw new Exception("Employee With This Id Does Not Exists");
            //}


        }
        public async Task<Emplyee> Delete(Emplyee employee)
        {
            _employeeDbContext.EmployeeTbl.Remove(employee);
            await _employeeDbContext.SaveChangesAsync();
            return employee;
        }
    }
}
