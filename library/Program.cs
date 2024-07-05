// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Solution;


namespace Solution
{
 public class Library
 {
    public string Name {get; set;}
    public string Location {get; set;}

   //  public string library(string name, string location) 
   //  {
   //      Name = name;
   //      Location = location;
   //  }
    public string DisplayInfo()
    {
      return $"Name: {Name} --- Location: {Location}";
    }
    
 }


//  public class Book
//  {

//  } 

//  public class Member
//  {
//     public string Name  = "Wella Lirary";
//     public string Email  = "wellaheath@gmail.com";
//  }

//  public class BorrowTransaction
//  {

//  }

// public class Person
// {
    
// }
public void  main([])
Library info = new();
info.Name = "WellaHealth";
info.Location = "Remote";

Console.WriteLine($"{info.DisplayInfo()}");

}

