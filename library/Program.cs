// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Solution;
 
  // entry point
Library newLibrary = new();
newLibrary.SetLibrary("WellaHealth", "Remote");
// info.Name = ;
// info.Location = ;

Console.WriteLine(newLibrary.DisplayInfo());

Book newBook = new();
newBook.SetBook("Text Book", "Amaechi", 2024);
Console.WriteLine(newBook.DisplayBookInfo());

Member newMember = new();
newMember.SetMember("Amaechi", "amaechi@wellahealth.com");
Console.WriteLine(newMember.DisplayMemberInfo());

Person newPerson = new();
newPerson.SetMember("Jude", "jude@wellahealth.com");
Console.WriteLine(newPerson.DisplayMemberInfo());