
namespace Solution
{
    // library class
 public class Library()
 {
    private string Name;// { get; set; }
    private string Location;// {get; set;}

    public void SetLibrary(string name, string location)// : this()
    {
        Name = name;
        Location = location;
    }
    public string DisplayInfo()
    {
        var output = $"Library\nName: {Name}\nLocation: {Location}\n";
        return output;
    }
    
 }

 //Book class
 public class Book()
 {
    private string? Name;// {get; set;}
    private string? Author;// {get; set;}
    private int? Year;// {get; set;}

    public void SetBook(string name, string author, int year)// : this()
    {
        Name = name;
        Author = author;
        Year = year;
    }

    public string DisplayBookInfo()
    {
        var output = $"Book Details\nName: {Name}\nAuthor: {Author}\nYear: {Year}\n";
        return output;
    }
 }

 // members class
 public class Member()
 {
    private string? Name;
    private string? Email;

    public void SetMember(string name, string email)
    {
        Name = name;
        Email = email;
    }
    public string DisplayMemberInfo()
    {
        var output = $"Member Details\nName: {Name}\nEmail: {Email}\n";
        return output;
    }
 }

 //Person base class to inherit member class
 public class Person() : Member()
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