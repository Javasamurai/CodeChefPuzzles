using System;

class CHEFEZQ
{
    static int daysPassed = 1;

    public static void Main(string[] args) {
        Console.WriteLine("Enter Number of cases");
        // string queries = Console.ReadLine();
        // Console.WriteLine(queries);
        
        // Chef got 100 queries
        // Chef took 10 queries each day
        // Chef will be free on 11th day

        int cases = int.Parse(Console.ReadLine());
        int K = 0; // Chef can take just these queries
        int max_days = 0; // Max days
        string[] queries;
        int currQueries = 0;
        
        for (int i = 0; i < cases; i++) {
            Console.WriteLine("Enter N and K");
            string firstLine = Console.ReadLine();

            max_days = int.Parse(firstLine.Split(" ")[0]);
            K = int.Parse(firstLine.Split(" ")[1]);
            
            Console.WriteLine("Enter Queries:");

            queries = Console.ReadLine().Split(" ");
            currQueries = CheckSpendDay(currQueries, K, int.Parse(queries[0] ));

            while (currQueries >= K)
            {
                if (daysPassed > queries.Length) {
                    currQueries = CheckSpendDay(currQueries, K);
                    // Console.WriteLine("Extra" + daysPassed);
                } else {
                    currQueries = CheckSpendDay(currQueries, K, int.Parse(queries[daysPassed - 1]));
                    // Console.WriteLine("Not Extra" + queries.Length);
                }
            }

            // do
            // {
            //     if (daysPassed > queries.Length) {
            //         currQueries = CheckSpendDay(currQueries, K);
            //         // Console.WriteLine("Extra" + daysPassed);
            //     } else {
            //         currQueries = CheckSpendDay(currQueries, K, int.Parse(queries[daysPassed - 1]));
            //         // Console.WriteLine("Not Extra" + queries.Length);
            //     }
            //     Console.WriteLine(currQueries);
            // } while (currQueries >= K);
            
            Console.WriteLine("Chef is free now at day!" + daysPassed);
        }
    }

    static int CheckSpendDay(int currQueries,int K, int query = 0) {
        int remainingQueries = currQueries + query - K;
        daysPassed++;

        Console.WriteLine("Queries Left: " + remainingQueries);
        return remainingQueries;
    }
}