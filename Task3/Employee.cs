using System;

namespace Task3
{
    class Employee
    {
        string name, surname, employeePosition;
        int employeeExperience;
        double employeeSalaryGross = 0;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string EmployeePosition { set { employeePosition = value; } }
        public int EmployeeExperience { set { employeeExperience = value; } }

        double EstablishASeniorityAllowance()
        {
            switch (employeePosition)
            {
                case "Тестировщик":
                    employeeSalaryGross = 40000;
                    if (employeeExperience == 0) employeeSalaryGross *= 1;
                    else if (employeeExperience == 1) employeeSalaryGross *= 1.3;
                    else if (employeeExperience == 2) employeeSalaryGross *= 1.5;
                    else employeeSalaryGross *= 1.7;
                    break;
                case "Инженер":
                    employeeSalaryGross = 50000;
                    if (employeeExperience == 0) employeeSalaryGross *= 1;
                    else if (employeeExperience == 1) employeeSalaryGross *= 1.3;
                    else if (employeeExperience == 2) employeeSalaryGross *= 1.5;
                    else employeeSalaryGross *= 1.7;
                    break;
                case "Программист":
                    employeeSalaryGross = 60000;
                    if (employeeExperience == 0) employeeSalaryGross *= 1;
                    else if (employeeExperience == 1) employeeSalaryGross *= 1.3;
                    else if (employeeExperience == 2) employeeSalaryGross *= 1.5;
                    else employeeSalaryGross *= 1.7;
                    break;
                default:
                    Console.WriteLine("Должность не задана");
                    break;
            }
            return employeeSalaryGross;
        }

        public void IdentifyEmployee()
        {
            Console.WriteLine("Информация о сотруднике:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}\nДолжность = {1}", name + " " + surname, employeePosition);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Оклад = {0}\t Налоговый сбор = {1}", EstablishASeniorityAllowance(), EstablishASeniorityAllowance() * 0.13);
        }
    }
}
