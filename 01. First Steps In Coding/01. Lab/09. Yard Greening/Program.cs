﻿double metersForGreening=double.Parse(Console.ReadLine());

double totalPrice = metersForGreening * 7.61;
double discount = totalPrice * 0.18;
double finalPrice = totalPrice - discount;

Console.WriteLine("The final price is: " + finalPrice + " lv.");
Console.WriteLine($"The discount is: {discount} lv.");