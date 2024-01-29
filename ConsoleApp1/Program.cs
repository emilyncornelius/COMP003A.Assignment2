/*
 * Author: Emily Cornelius
 * Course: COMP 003A
 * Purpose: Week 2 Assignment
 */
Console.Title = "COMP-003A - Assignment 2";
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("****************************************");
Console.WriteLine("String Section");
Console.WriteLine("****************************************");

string namePrompt = "Enter First Name: ";
Console.Write(namePrompt);
string firstName = Console.ReadLine();

namePrompt = "Enter Middle Name: ";
Console.Write(namePrompt);
string middleName = Console.ReadLine();

namePrompt = "Enter Last Name: ";
Console.Write(namePrompt);
string lastName = Console.ReadLine();

namePrompt = "Enter age in 2023: ";
Console.Write(namePrompt);
string inputAge = Console.ReadLine();

int yearBorn = 2023 - Convert.ToInt32(inputAge);
Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.\n\n");

Console.WriteLine("****************************************");
Console.WriteLine("Math Section");
Console.WriteLine("****************************************");

string numberprompt = "Enter an integer for integer1: ";
Console.Write(numberprompt);
string integerprompt = Console.ReadLine();
int integer1 = Convert.ToInt32(integerprompt);

numberprompt = "Enter an integer for integer2: ";
Console.Write(numberprompt);
integerprompt = Console.ReadLine();
int integer2 = Convert.ToInt32(integerprompt);

Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2} \n\n");

Console.WriteLine("****************************************");
Console.WriteLine("Circle Area & Circumference Calculator Section");
Console.WriteLine("****************************************");

string radiusprompt = "Enter radius: ";
Console.WriteLine(radiusprompt); 
double radius = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
double circumference = 2 * Math.PI * radius;
string areaprompt = "The area is ";
Console.WriteLine(areaprompt + $"{area}");
areaprompt = "The circumference is ";
Console.WriteLine(areaprompt + $"{circumference}");


