﻿using System;
class Program
{
    static void Main(string[] args)
    {
        int centuries = int.Parse(Console.ReadLine());
        var years = centuries * 100;
        var days = (int)(years * 365.2422);
        var hours = days * 24;
        var minutes = hours * 60;
        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
    }
}

