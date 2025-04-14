using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        public static void Main2()
        {
            try
            {
                var list = new FillTeachers().Fill();

                new PrintAll().Print(list);
                new Dept2MonthAvg().ShowAvg(list);
                new OverUniAvg().ShowAboveAvg(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
