﻿using System;
public class age
{
    public static void Main()
    {
        int age;
        Console.Write("Enter your age ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("You look younger than {0} ", age);
    }
}