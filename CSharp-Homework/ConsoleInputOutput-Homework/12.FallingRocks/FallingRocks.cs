using System;
using System.Threading;
using System.Collections.Generic;

namespace FallingRocks
{

    struct Object //структура, обединяваща всички променливи, които ще се използват (трябва да са публични)
    {
        public int x;
        public int y;
        public char ch;
        public ConsoleColor color;
    }

    class FallingRocks
    {
        static void PrintOnPosition(int x, int y, char ch, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(ch);
        }
        static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            Console.BufferHeight = Console.WindowHeight = 30; //премахва на скроловете отстрани и отдолу
            Console.BufferWidth = Console.WindowWidth = 50;
            int playfieldWidth = 30; //дефинира размера на игралното поле
            int livesCount = 3; //дефинира животите
            int score = 0; //дефинира точки
            double speed = 0; //дефинира скорост 

            Object dwarf = new Object(); //информацията за джуджето
            dwarf.x = 15;
            dwarf.y = Console.WindowHeight - 1;
            dwarf.ch = 'O';
            dwarf.color = ConsoleColor.White;
            Random randomGenerator = new Random(); //генератор на случайни числа
            List<Object> objects = new List<Object>(); //списък. където ще се пазят данните за обектите

            while (true)
            {
                bool hitted = false;
                //Creating rocks 
                {
                    int chance = randomGenerator.Next(0, 100);
                    if (chance < 10) // в 10% от случаите създава бонус живот
                    {
                        Object newObject = new Object(); //създава бонус и го добавя в списъка
                        newObject.x = randomGenerator.Next(0, playfieldWidth);
                        newObject.y = 0;
                        newObject.ch = '\u263a';
                        newObject.color = ConsoleColor.Cyan;
                        objects.Add(newObject);
                    }
                    else if (chance < 20) //в 20% от случаите създава бонус намаляване на скоростта
                    {
                        Object newObject = new Object(); //създава бонус и го добавя в списъка
                        newObject.x = randomGenerator.Next(0, playfieldWidth);
                        newObject.y = 0;
                        newObject.ch = 'S';
                        newObject.color = ConsoleColor.Yellow;
                        objects.Add(newObject);
                    }
                    else //в другите 80% създава скала
                    {
                        Object newObject = new Object();
                        char[] ch = new char[] { '!', '@', '#', '%', '^', '&', '*' };
                        int i = randomGenerator.Next(0, ch.Length);
                        int number = randomGenerator.Next(0, 100);
                        int rockLength;
                        if (number < 70)
                        {
                            rockLength = 1;
                        }
                        else if (number < 95)
                        {
                            rockLength = 2;
                        }
                        else
                        {
                            rockLength = 3;
                        }
                        newObject.x = randomGenerator.Next(0, playfieldWidth);
                        newObject.y = 0;
                        newObject.ch = ch[i];
                        newObject.color = (ConsoleColor)randomGenerator.Next(9, 15);
                        objects.Add(newObject);
                    }
                }
                // Move dwarf (key pressed) 
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) //за да върви по-плавно играта
                    {
                        Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow) //преместване на джуджето наляво
                    {
                        if (dwarf.x - 1 >= 1)
                        {
                            dwarf.x = dwarf.x - 1;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow) //преместване на джуджето надясно
                    {
                        if (dwarf.x + 1 < playfieldWidth - 1)
                        {
                            dwarf.x = dwarf.x + 1;
                        }
                    }
                }

                // Move rocks 
                List<Object> newList = new List<Object>();
                for (int i = 0; i < objects.Count; i++)
                {
                    Object oldObject = objects[i];
                    Object newObject = new Object();
                    newObject.x = oldObject.x;
                    newObject.y = oldObject.y + 1;
                    newObject.ch = oldObject.ch;
                    newObject.color = oldObject.color;

                    // Check if objects are hitting dwarf 
                    if (newObject.ch == 'S' && newObject.y == dwarf.y && newObject.x == dwarf.x) //ако вземем бонус скорост
                    {
                        speed -= 20;
                        hitted = true;
                    }
                    else if (newObject.ch == '\u263a' && newObject.y == dwarf.y && newObject.x == dwarf.x) //ако вземем бонус живот
                    {
                        livesCount++;
                        hitted = true;
                    }
                    else if (newObject.y == dwarf.y && newObject.x == dwarf.x)
                    {
                        livesCount--;
                        speed += 10;
                        hitted = true;
                    }
                    if (newObject.y < Console.WindowHeight)
                    {
                        newList.Add(newObject);
                    }
                    else
                    {
                        score++;
                    }
                }
                objects = newList;

                // Clear the console 
                Console.Clear();

                // Draw "Game over" 
                if (livesCount <= 0)
                {
                    PrintStringOnPosition(15, 8, "GAME  OVER  !!!", ConsoleColor.Red);
                    PrintStringOnPosition(15, 16, "Your score is:" + score, ConsoleColor.Red);
                    PrintStringOnPosition(15, 24, "Press [Enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    return;
                }

                // Redraw playfield 
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    PrintOnPosition(playfieldWidth, i, '|', ConsoleColor.White);
                }
                foreach (Object newObject in objects)
                {
                    PrintOnPosition(newObject.x, newObject.y, newObject.ch, newObject.color);
                }
                if (hitted)
                {
                    PrintOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
                    objects.Clear();
                }
                else
                {
                    PrintOnPosition(dwarf.x, dwarf.y, dwarf.ch, dwarf.color);
                }

                // Draw info 
                PrintStringOnPosition(35, 8, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(35, 16, "Speed: " + speed, ConsoleColor.White);
                PrintStringOnPosition(35, 24, "Score: " + score, ConsoleColor.White);

                // Slow down program 
                speed++;
                if (speed > 400)
                {
                    speed = 400;
                }
                Thread.Sleep((int)(400 - speed));
            }
        }
    }
}

