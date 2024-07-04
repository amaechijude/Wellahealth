using System.Dynamic;

namespace Solution
{
 public class Library
 {
    private string Name  = "Wella Lirary"; //{get; set;}
    private string Location = "Remote";

    public string DisplayInfo() 
    {
        return $"Name: {Name}, --- Location: {Location}";
    }

    
 }


 public class Book
 {

 } 

 public class Member
 {
    public string Name  = "Wella Lirary";
    public string Email  = "wellaheath@gmail.com";
 }

 public class BorrowTransaction
 {

 }

public class Person
{
    
}

}

// namespace BookNamespace
// {
//  public class Book {
// 	public string Title {get; set;}
// 	public string Author {get; set;}
// 	}    
// }