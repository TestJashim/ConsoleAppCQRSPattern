namespace ConsoleAppCQRSPattern.Repositories
{
    public class EmployeeCommandsRepository : IEmployeeCommandsRepository
    {
        public void SaveEmployee(Employee employee)
        {
            // Persist the employee record in a data store
        }
    }
}


#region DbContext

/* 
using ConsoleAppCQRSPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppCQRSPattern.Repositories
{
    public class EmployeeCommandsRepository : IEmployeeCommandsRepository
    {
        private readonly YourDbContext dbContext;

        public EmployeeCommandsRepository(YourDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void SaveEmployee(Employee employee)
        {
            // Add the employee to the context
            dbContext.Employees.Add(employee);

            // Save changes to the database
            dbContext.SaveChanges();
        }
    }
}
 */
#endregion
