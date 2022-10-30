// See https://aka.ms/new-console-template for more information
using Exercises;

exerciseclass exercise = new exerciseclass();
//Console.WriteLine("input your name");
//string a=Console.ReadLine();
//string result = exerciseclass.Name( a);
//Console.WriteLine( result );
//Console.WriteLine("Input a number for a");
//int a=int.Parse(Console.ReadLine());
//Console.WriteLine("Input another number for b");
//int b=int.Parse(Console.ReadLine());
//exerciseclass.BiggerNumber(a, b);
Console.WriteLine("enter a number and i will give you the last digit in word");
int a = int.Parse(Console.ReadLine());
int result =exerciseclass.DigitWord(a);
Console.WriteLine("The last digit is " +result);