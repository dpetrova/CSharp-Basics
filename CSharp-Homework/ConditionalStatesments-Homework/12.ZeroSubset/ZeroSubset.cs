using System;

class ZeroSubset
{
    static void Main()
    {
        //Console.SetBufferSize(100, 1000);
        Console.Write("enter 5 integer numbers, separeted by a space:");
        string[] numbers = Console.ReadLine().Split();
        int[] set = new int[numbers.Length];
        for (int i = 0; i < set.Length; i++)
        {
            set[i] = int.Parse(numbers[i]);
        }
        int count = 0;
        for (int i = 0; i < set.Length; i++)
        {
            for (int j = 0; j < set.Length; j++)
            {
                if (i != j)
                {
                    if (set[i] + set[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", set[i], set[j]);
                        count++;
                    }
                }
            }
        }
        for (int i = 0; i < set.Length; i++)
        {
            for (int j = 0; j < set.Length; j++)
            {
                for (int k = 0; k < set.Length; k++)
                {
                    if (i != j && i != k && j != k)
                    {
                        if (set[i] + set[j] + set[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", set[i], set[j], set[k]);
                            count++;
                        }
                    }
                }
            }
        }
        for (int i = 0; i < set.Length; i++)
        {
            for (int j = 0; j < set.Length; j++)
            {
                for (int k = 0; k < set.Length; k++)
                {
                    for (int l = 0; l < set.Length; l++)
                    {
                        if (i != j && i != k && i != l && j != k && j != l && k != l)
                        {
                            if (set[i] + set[j] + set[k] + set[l] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", set[i], set[j], set[k], set[l]);
                                count++;
                            }
                        }
                    }
                }
            }
        }
        for (int i = 0; i < set.Length; i++)
        {
            for (int j = 0; j < set.Length; j++)
            {
                for (int k = 0; k < set.Length; k++)
                {
                    for (int l = 0; l < set.Length; l++)
                    {
                        for (int m = 0; m < set.Length; m++)
                        {
                            if (i != j && i != k && i != l && i != m && j != k && j != l && j != m && k != l && k != m && l != m)
                            {
                                if (set[i] + set[j] + set[k] + set[l] + set[m] == 0)
                                {
                                    Console.WriteLine("{0} + {1} + {2} + {3} +{4} = 0", set[i], set[j], set[k], set[l], set[m]);
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}
