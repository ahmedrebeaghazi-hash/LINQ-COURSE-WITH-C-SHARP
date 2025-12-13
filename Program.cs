using FunctionalProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Projection
{
internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            Console.WriteLine("---------------------------------");
            RunExample02();
            Console.WriteLine("---------------------------------");
            RunExample03();
            Console.ReadKey();
        }
        private static void RunExample01()
        {
            List<string> Words = new List<string>() { "i", "love", "ASP.Net", "Core" };
            var result01 = Words.Select(x => x.ToUpper());
            var result02 = from word in Words 
                           select word.ToUpper();
            foreach (var word in result02)
            {
                Console.WriteLine(word);
            }
       //     var result = Words.Select( x => { return x; }); the same 
        }
        private static void RunExample02()
        {
            List<int> Numbers = new List<int>() { 1,2,3,5,7 };
            var result03 = Numbers.Select(x => x * x);
           // var result04 = from n in Numbers
                           //select n * n;
            foreach (var n in result03)
            {
                Console.WriteLine(n);
            }
            
        }
        private static void RunExample03()
        {
 var Employees = Repository.LoadEmployees();
            var result = Employees.Select(x => {
                return new EmployeesDTO
                {
                    Name = $"{x.Name}",
                    EmployeeSkills = x.Skills.Count()

                }; });
            foreach (var Emp in result)
            {
                Console.WriteLine($"{Emp.ToString()}");
            }
        }
    }
}
