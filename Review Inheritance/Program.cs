using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> Employees = new Dictionary<string, Dictionary<string, string>>()
            {
                {"emp1",new Dictionary<string , (string , List<(DateTime,string)>)>{ {"EmployeeName","deepan" }{"password","Emp123" },{"position","employee" }} }
            };

            Console.Write("Enter the EmployeeId:");
            Program program = new Program();
            program.AddEmployee(Employees);
            Console.WriteLine();
           

        }
        public void AddEmployee(Dictionary<string, Dictionary<string, string>> Employees)
        {
            char Opt = '+';
            while (Opt == '+')
            {
                string EmpId = Console.ReadLine();
                Console.Write("Enter our Password:");
                string Pwd = Console.ReadLine();
                Console.Write("Enter youur position");
                string Pos = Console.ReadLine();
                Employees[EmpId] = new Dictionary<string, string>() { { "PassWord", Pwd }, { "Postion", Pos } };
                Console.Write("Enter \'+\' to Add More Employees");
                Opt = char.Parse(Console.ReadLine());
            }

        }

        //public void DisplayData(Dictionary<string, Dictionary<string, string>> Employees, KeyValuePair keyValuePair)
        //{
        //    foreach (keyValuePair < string,Dictionary<string, string> dic in Employees)
        //    {

        //    }
        //}
    }
}