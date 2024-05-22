// See https://aka.ms/new-console-template for more information
// public class Person
// {
//     private string name;

//     public string Name 
//     {
//         get { return name; }
//         set { name = value; }
//     }
// }
using MyName; 
using MyBank;

Person tez = new();
tez.Name = "Amaechi";
var t = tez.Name;

Bank bal = new();
var a = bal.BankA = 200;
var b = bal.BankB = 300;
var c = bal.BankC = 500;

Console.WriteLine(t);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
