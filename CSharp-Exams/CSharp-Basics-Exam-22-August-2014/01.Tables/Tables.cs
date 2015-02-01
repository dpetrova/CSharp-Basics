using System;

class Tables
{
    //Gosho is very good table maker. He has 4 bundles full of table legs. Every bundle holds packets. The first bundle holds
    //packets with 1 leg, the second bundle holds packets with 2 legs and the other 2 bundles hold packets with 3 and 4 legs 
    //respectively. Example: (bundle3 = 5 packets * 3 legs = 15 legs). He also has T amount of table tops and N amount of 
    //tables that need to be made. Your task is to calculate how many tables can Goshko make and whether he has made more, 
    //less or equal amount of the needed tables. Every table is made from 4 legs and 1 table top.  
    //Input
    //The input data should be read from the console.
    //•	At the first four lines you will be given integer numbers  representing how many packets each bundle has
    //•	At the fifth line an integer number T specifying the amount of table tops.
    //•	At the sixth line an integer number N specifying the amount of tables to be made.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of 1 or 2 lines:
    //•	Print “more: {0}” on the first line, if the tables made are more than the tables needed.
    //o	Print the materials left on the second line: “tops left: {0}, legs left: {1}”
    //•	Print “less: {0} “, if the tables made are less than the tables needed. 
    //o	Print the materials needed  to create all needed tables: “tops needed: {0}, legs needed: {1}”
    //•	Print “Just enough tables made: {0}”, if the tables made are equal with the tables needed.
    //Constraints
    //•	The inputs will be an integers in the range [0…999 999 999].
    //•	Allowed working time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        long packetsInBundle1 = long.Parse(Console.ReadLine());
        long packetsInBundle2 = long.Parse(Console.ReadLine());
        long packetsInBundle3 = long.Parse(Console.ReadLine());
        long packetsInBundle4 = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long tablesNeeded = long.Parse(Console.ReadLine());
        long neededTops = tablesNeeded;
        long neededLegs = tablesNeeded * 4;
        long allLegs = (packetsInBundle1 * 1) + (packetsInBundle2 * 2) + (packetsInBundle3 * 3) + (packetsInBundle4 * 4);
        long legsForTable = allLegs / 4;
        long madeTables = Math.Min(tableTops, legsForTable);
        long topsLeft = 0;
        long legsLeft = 0;
        long topsLack = 0;
        long legsLack = 0;
        if (tableTops > neededTops)
        {
            topsLeft = tableTops - neededTops;
        }
        else
        {
            topsLack = neededTops - tableTops;
        }
        if (allLegs > neededLegs)
        {
            legsLeft = allLegs - neededLegs;
        }
        else
        {
            legsLack = neededLegs - allLegs;
        }
        if (madeTables > tablesNeeded)
        {
            Console.WriteLine("more: {0}", madeTables - tablesNeeded);
            Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
        }
        else if (tablesNeeded > madeTables)
        {
            Console.WriteLine("less: {0}", madeTables - tablesNeeded);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsLack, legsLack);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", madeTables);
        }
    }
}
