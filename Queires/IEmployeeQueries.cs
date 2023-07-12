using ConsoleAppCQRSPattern.DTOs;

namespace ConsoleAppCQRSPattern.Queires
{
    public interface IEmployeeQueries
    {
        EmployeeDTO FindByID(int employeeID);
    }
}
