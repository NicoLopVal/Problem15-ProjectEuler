using System;

namespace Problem15_ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 20;
            int columns = 20;
            double totalPaths = 1;
            
            for(int i = 1; i <= rows; i++)
            {
                totalPaths = totalPaths * (rows + i) / i;
            }
            
            Console.WriteLine("The total paths possible for a {0}x{1} grid are: {2}",rows,columns, totalPaths);
        }
    }
}
