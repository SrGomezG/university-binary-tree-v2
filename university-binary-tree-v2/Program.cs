using System;

namespace university_binary_tree_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;
            rectorPosition.Tax = 0.28f;

            Position vicRecPosition = new Position();
            vicRecPosition.Name = "Vicerector financiero";
            vicRecPosition.Salary = 750;
            vicRecPosition.Tax = 0.23f;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;
            contadorPosition.Tax = 0.18f;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.Tax = 0.2f;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria financiera 1";
            secFin1Position.Salary = 350;
            secFin1Position.Tax = 0.14f;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria financiera 2";
            secFin2Position.Salary = 310;
            secFin2Position.Tax = 0.12f;

            Position vicRecAcaPosition = new Position();
            vicRecAcaPosition.Name = "Vicerector academico";
            vicRecAcaPosition.Salary = 780;
            vicRecAcaPosition.Tax = 0.26f;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe reg";
            jefeRegPosition.Salary = 640;
            jefeRegPosition.Tax = 0.21f;

            Position secretg2Position = new Position();
            secretg2Position.Name = "Secretg2";
            secretg2Position.Salary = 360;
            secretg2Position.Tax = 0.15f;

            Position secretg1Position = new Position();
            secretg1Position.Name = "Seretg1";
            secretg1Position.Salary = 400;
            secretg1Position.Tax = 0.16f;

            Position asist2Position = new Position();
            asist2Position.Name = "Asist2";
            asist2Position.Salary = 170;
            asist2Position.Tax = 0.08f;

            Position asist1Position = new Position();
            asist1Position.Name = "Asist1";
            asist1Position.Salary = 250;
            asist1Position.Tax = 0.11f;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;
            mensajeroPosition.Tax = 0.05f;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicRecPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicRecPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicRecPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicRecAcaPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicRecAcaPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secretg2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secretg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secretg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asist1Position, secretg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asist2Position.Name);

            //Version 1.0
            universityTree.PrintTree(universityTree.Root);
            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: {totalSalary}");

            //Version 2.0

            //Point 2.1
            universityTree.LongestSalary(universityTree.Root);
            Console.WriteLine($"The longest salary is: {universityTree.longestSalary}");

            //Point 2.2
            float averageSalaries = universityTree.Average(universityTree.Root);
            Console.WriteLine($"Average salaries: {averageSalaries}");

            //Point 2.3
            Console.WriteLine("Enter a Name:");
            String search = Console.ReadLine();
            float salaryByPosition = universityTree.SalaryPosition(universityTree.Root, search);
            Console.WriteLine($"The salary of {search} is: {salaryByPosition}");

            //Point 2.4.1
            float totalTaxes = universityTree.AddTaxes(universityTree.Root);
            Console.WriteLine($"Total taxes: {totalTaxes}");
        }
    }
}
