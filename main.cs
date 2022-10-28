// Created by: Mikey Gloriani
// Created on: Oct 2022
//
// This program displays the area of a trapezoid


using System;

class Program {
    public static void Main (string[] args) {
        // This function accepts user input
        int aBase;
        int bBase;
        int height;
        int area;

        Console.WriteLine("This program calculates the area of a trapezoid.");
        Console.WriteLine("");

        Console.Write("Enter the base for A (cm): ");
        aBase = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the base for B (cm): ");
        bBase = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        area = ((aBase+bBase)/2)*height;

        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm². ");

        Console.WriteLine("\nDone.");
    }
}
