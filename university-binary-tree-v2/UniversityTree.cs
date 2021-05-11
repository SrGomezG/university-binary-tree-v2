using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_binary_tree_v2
{
    class UniversityTree
    {
        public PositionNode Root;
        public float count = 0;
        public float longestSalary = 0;
        public void CreatePosition(PositionNode parent, Position positionToCreate, string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            if (parent == null)
            {
                return;
            }

            if (parent.Position.Name == parentPositionName)
            {
                if (parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }
                parent.Right = newNode;
                return;
            }

            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);

        }

        public void PrintTree(PositionNode from)
        {
            if (from == null)
            {
                return;
            }
            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");

            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        public float AddSalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right);
        }

        //Code for 2.2
        public float CountNodes(PositionNode from)
        {
            if (from == null)
            {
                return count;
            }
            count++;

            CountNodes(from.Left);
            return CountNodes(from.Right);
        }

        //Code for 2.2
        public float Average(PositionNode from)
        {
            return AddSalaries(from) / CountNodes(from);
        }

        //Code for 2.4.1
        public float AddTaxes(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return (from.Position.Salary * from.Position.Tax) + AddTaxes(from.Left) + AddTaxes(from.Right);
        }

        //Code for 2.3
        public float SalaryPosition(PositionNode from, string name)
        {
            if (from == null)
            {
                return 0;
            }
            if(from.Position.Name == name)
            {
                return from.Position.Salary;
            }
            return SalaryPosition(from.Left, name) + SalaryPosition(from.Right, name);
        }

        //Code for 2.1
        public void LongestSalary(PositionNode from)
        {
            if (from == null)
            {
                return;
            }
            if (from.Position.Salary > longestSalary && from.Position.Salary != Root.Position.Salary)
            {
                longestSalary = from.Position.Salary;
            }
            LongestSalary(from.Left);
            LongestSalary(from.Right);
        }
    }
}

