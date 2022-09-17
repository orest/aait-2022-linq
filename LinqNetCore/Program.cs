using LinqNetCore.Processors;

namespace LinqNetCore {
    internal class Program {
        static void Main(string[] args)
        {
            var stats = new OrganizationStats();
            Console.WriteLine(stats.GetTotalEmployeeCount());

            //Filtering();
            //Sorting();
            //Sets();
            //Quantifiers();
            //Projection();
            //Joins();
            //Grouping();
            //Generation();
            //Aggregation();

            Console.WriteLine("Hello, World!");
        }
    }
}