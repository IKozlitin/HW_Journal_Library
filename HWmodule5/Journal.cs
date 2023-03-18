using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Journal
{
    class Journal
    {
        public int employeeNumber { get; set; }
                        
        public override string ToString()
        {
            return $"{employeeNumber}";
        }

        public static Journal operator+(Journal j, int plus)
        {
            j.employeeNumber = j.employeeNumber + plus;
            return j; 
        }
        public static Journal operator-(Journal j, int minus)
        {
            j.employeeNumber = j.employeeNumber - minus;
            return j;
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Journal j1, Journal j2)
        {
            return j1.employeeNumber == j2.employeeNumber;
        }
        public static bool operator !=(Journal j1, Journal j2)
        {
            return j1.employeeNumber != j2.employeeNumber;
        }
        public static bool operator >(Journal j1, Journal j2)
        {
            return (j1.employeeNumber > j2.employeeNumber);
        }
        public static bool operator <(Journal j1, Journal j2)
        {
            return (j1.employeeNumber < j2.employeeNumber);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal j1 = new Journal {employeeNumber = 50};
            Journal j2 = new Journal {employeeNumber = 100};
            WriteLine($"Количество сотрудников:\n 1jour = {j1} 2jour = {j2}");

            WriteLine("------------------------------");

            Write("Принято сотрудников jour1: ");
            int plus = int.Parse(ReadLine());
            WriteLine($"Стало jour1: {j1+plus}");

            WriteLine("------------------------------");

            Write("Уволено сотрудников jour1: ");
            int minus = int.Parse(ReadLine());
            WriteLine($"Стало jour1: {j1-minus}");

            WriteLine("------------------------------");
           
            WriteLine($"{j1} == {j2}: {(j1==j2)}");
            WriteLine($"{j1} != {j2}: {(j1!=j2)}");

            WriteLine("------------------------------");

            WriteLine($"{j1} > {j2}: {(j1>j2)}");
            WriteLine($"{j1} < {j2} : {(j1<j2)}");

        }
    }
}