/*
 Great Pattern. Has lots of potential to get rid of swtich cases 
*/
namespace DesignPattern
{
    public abstract class EmployeeType
    {
        public abstract decimal BonusSize { get; }
    }

    public class Manager : EmployeeType
    {
        public override decimal BonusSize => 100m;
    }

    public class TeamLead : EmployeeType
    {
        public override decimal BonusSize => 20m;
    }

    public class Employee
    {
        public decimal Bonus { get; set; }
        public EmployeeType Type { get; set; }
    }


    public static class BusinessLogic
    {
        public static void ProcessBonus(Employee employee)
        {
            employee.Bonus = employee.Type.BonusSize;
        }
    }
}