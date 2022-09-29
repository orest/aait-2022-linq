using LinqNetCore.Models;
using LinqNetCore.Processors;

namespace LinqNetCore {
    internal class Program {
        static void Main(string[] args)
        {

            var preLinq = new PreLinq();
            preLinq.Run();


            var stats = new OrganizationStats();
            Console.WriteLine(stats.GetTotalEmployeeCount());

            //Filtering();
            //Sorting();
            //Sets();
            //Quantifiers();
            //Projection();
            //Joins();
            //Grouping();
            //Aggregation();

            Console.WriteLine("Hello, World!");
        }
    }
}