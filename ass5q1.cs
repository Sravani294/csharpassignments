﻿using System.Collections;
using Assignment__5;

public class Q2
{
    public static void Main(string[] args)
    {
        var emp = new EmpDetails();

        ArrayList Emp_1 = new ArrayList();

        Console.WriteLine("Please Enter The Player 1 ID : ");
        emp.Emp1_Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter The Player 1 Name : ");
        emp.Emp1_Name = Console.ReadLine().ToString();

        Console.WriteLine("Please Enter The Player 1 Company : ");
        emp.Emp1_Company = Console.ReadLine().ToString();

        Emp_1.Add(emp.Emp1_Id);

        Emp_1.Add(emp.Emp1_Name);

        Emp_1.Add(emp.Emp1_Company);

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("-------------------------Emp 1 Array List Details----------------------------");
        Console.WriteLine("-----------------------------------------------------------------------------");

        foreach (var str in Emp_1)

        {

            Console.WriteLine(str);

        }
        ArrayList Emp_2 = new ArrayList();

        Console.WriteLine("Please Enter The Player 2 ID : ");
        emp.Emp2_Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter The Player 2 Name : ");
        emp.Emp2_Name = Console.ReadLine().ToString();

        Console.WriteLine("Please Enter The Player 2 Company : ");
        emp.Emp2_Company = Console.ReadLine().ToString();

        Emp_2.Add(emp.Emp2_Id);

        Emp_2.Add(emp.Emp2_Name);

        Emp_2.Add(emp.Emp2_Company);

        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("-------------------------Emp 2 Array List Details----------------------------");
        Console.WriteLine("-----------------------------------------------------------------------------");

        foreach (var str in Emp_2)

        {

            Console.WriteLine(str);

        }
        Console.ReadLine();
    }
}

namespace Assignment__5
{
    class EmpDetails
    {
        internal int Emp1_Id;
        internal string Emp1_Name;
        internal string Emp1_Company;
        internal int Emp2_Id;
        internal string Emp2_Name;
        internal string Emp2_Company;

        public EmpDetails()
        {
        }
    }
}