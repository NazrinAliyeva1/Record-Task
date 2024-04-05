using Record_Task.Models;
using System.Xml.Linq;

namespace Record_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 std = new Class1("Nazrin", "Aliyeva", 20, "BackEnd Developer.");
            Class1 std2 = std with { Name = "Sefa", Surname = "Mikayilova", Age = 54, Job = "Doctor" };
            Console.WriteLine(std);
            Console.WriteLine(std2);
            //Class1 std2 = new Class1("A", "B");
            Console.WriteLine(Object.ReferenceEquals(std, std2));
            Console.WriteLine(std==std2);
        }
    }
}
