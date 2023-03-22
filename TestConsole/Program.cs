using PNGSchemaGenerator.SchemaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            var jobPosting = new JobPosting()
            {
                Title = "developer",
                AlternateName = "shit",
                BaseSalary  = 27
            };

            Console.WriteLine(jobPosting.ToString());
            Console.ReadKey();
        }
    }
}
