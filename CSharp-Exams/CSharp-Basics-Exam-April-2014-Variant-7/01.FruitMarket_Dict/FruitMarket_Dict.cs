using System;
using System.Collections.Generic;

class FruitMarket
{
    //The local fruit market offers fruits and vegetables with the following standard price list:
    //•	banana -> 1.80
    //•	cucumber -> 2.75
    //•	tomato -> 3.20
    //•	orange -> 1.60
    //•	apple -> 0.86
    //The market owner decided to introduce the following discounts:
    //•	Friday -> 10% off for all products
    //•	Sunday -> 5% off for all products
    //•	Tuesday -> 20% off for fruits
    //•	Wednesday -> 10% off for vegetables
    //•	Thursday -> 30% off for bananas
    //Write a program that helps the fruit market owner to calculate the total price for orders that consist of day,
    //3 products with quantities.
    //Input
    //The input data should be read from the console. The input data consists of exactly 7 lines:
    //•	At the first line you will be given the day of week. 
    //•	At the next 6 lines you will be given: quantity1, product1, quantity2, product2, quantity3, product3.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //You have to print at the console the total price for the specified 3 products at the specified day of week.
    //Constraints
    //•	The day of week is one of the values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday. 
    //•	The product quantities (quantity1, quantity2, quantity3) will be a number in the range [1…100], with up to 2 digits
    //after the decimal point. The will be used "." as decimal separator.
    //•	The products names (product1, product2, product3) is one of the values: banana, cucumber, tomato, orange, and apple.
    //•	The fruits are banana, orange and apple. The vegetables are tomato and cucumber.
    //•	The total price should be rounded to exactly 2 digits after the decimal point (use "." as decimal separator).
    //•	Allowed work time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        double quantity1 = double.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        double quantity2 = double.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        double quantity3 = double.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();
        Dictionary<string, double> order = new Dictionary<string, double>();
        order[product1] = quantity1;
        order[product2] = quantity2;
        order[product3] = quantity3;
        double price = 0;
        double priceOff = 0;
        double totalPrice = 0;
        bool isFruit = false;

        foreach (KeyValuePair<string, double> entry in order)
        {
            switch (entry.Key)
            {
                case "banana": price = 1.80; isFruit = true; break;
                case "cucumber": price = 2.75; isFruit = false; break;
                case "tomato": price = 3.20; isFruit = false; break;
                case "orange": price = 1.60; isFruit = true; break;
                case "apple": price = 0.86; isFruit = true; break;
            }

            switch (dayOfWeek)
            {
                case "Monday": priceOff = price * 0.0; break;
                case "Tuesday":
                    if (isFruit == true)
                        priceOff = price * 0.2;
                    else priceOff = price * 0.0; break;
                case "Wednesday":
                    if (isFruit == false)
                        priceOff = price * 0.1;
                    else priceOff = price * 0.0; break;
                case "Thursday":
                    if (entry.Key == "banana")
                        priceOff = price * 0.3;
                    else priceOff = price * 0.0; break;
                case "Friday": priceOff = price * 0.1; break;
                case "Saturday": priceOff = price * 0.0; break;
                case "Sunday": priceOff = price * 0.05; break;
            }
            totalPrice += entry.Value * (price - priceOff);
        }
        Console.WriteLine("{0:0.00}", totalPrice);
    }
}
