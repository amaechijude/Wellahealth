// See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
//  using System.Collections.Generic;

using System.Collections.ObjectModel;

// // Question 1
// List<string> colours = new List<string> {"red", "green", "blue"};

List<string> colours = ["red", "green", "blue"];
// Modification below worked
colours.Add ("black");

// Converts the above list to read only colllection
ReadOnlyCollection<string> colour_read_only = colours.AsReadOnly();

// The modification below throws an error
//colour_read_only.Add ("purple");

Console.WriteLine($"[{string.Join(",", colour_read_only)}]");

// Question 2: Resizing list

List<int> hundred_numbers = [22, 28, 28, 19, 7, 49, 37, 14, 39, 46, 19, 30, 39, 45, 31,
                            36, 43, 39, 22, 49, 8, 14, 49, 11, 20, 28, 14, 9, 39, 16, 20,
                            44, 44,50, 4, 12, 32, 42, 46, 34, 17, 22, 45, 48, 29, 11, 46,
                            26, 48, 1, 12, 36, 30, 33, 7, 20, 29, 11, 15, 7, 40, 37, 10, 
                            45, 6, 1, 16,40, 11, 16, 44, 7, 24, 31, 18, 16, 5, 2, 16, 25,
                            29, 46, 50, 26, 26, 4, 50, 9, 12, 37, 48, 43, 28, 9, 40, 5, 31, 38, 17, 34];

hundred_numbers.Add(32);
hundred_numbers.Add(12);
hundred_numbers.Add(42);
hundred_numbers.Add(13);
hundred_numbers.Add(72);
hundred_numbers.Add(2);
hundred_numbers.Add(31);
hundred_numbers.Add(19);
hundred_numbers.Add(54);
hundred_numbers.Add(9);

// Console.WriteLine(hundred_numbers);
// foreach (var item in hundred_numbers)
// {
//     Console.WriteLine(item);
// }


// Question 3: Findind the maximum value in a list
List<int> nums = [3, 8, 2, 9];
int max_num = nums.Max();

Console.WriteLine($"The max number is: {max_num}");

// Question 4: Merge two arrays

int[] array1 = {1, 2, 3};
int[] array2 = {4, 5, 6};
int[] merged_array = array1.Concat(array2).ToArray();

Console.WriteLine($"{string.Join(", ", merged_array)}");

// Question 5:
public class Book {
	public string Title {get; set;}
	public string Author {get; set;}
	}

List<Book> bookList = new List<Book>();
bookList.Add(new Book {Title = "Purple Hibiscus", Author = "Chimamanda Adichie"});
bookList.Add(new Book {Title = "School of Darkness", Author = "Bella Dodd"});
bookList.Add(new Book {Tile = "Franklin Cover Up", Author = "John DeCamp"});

// iterate and Print the books
for (i = 0; i < bookList.Count; i++)
{
	Book book = bookList[i];
	Console.WriteLine($"Book {i+1}");
	Console.WriteLine($"Title: {book.Tile}");
	Console.WriteLine($"Autbor: {book.Author}");
	Console.WriteLine("  ")
}



// Question 6: Sorting and reversing
int[] array_to_sort = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5};

Array.Sort(array_to_sort);
Console.WriteLine(array_to_sort);
// Reverse

Array.Reverse(array_to_sort);
Console.WriteLine(array_to_sort);

// Question 7: Array Length
//
int[] nums_array = {10, 20, 30, 40, 50};
var nums_array_len = nums_array.Length;
Console.WriteLine(nums_array_len);

// Question 8: List Comprehension

List<string> fruits = ["apple", "banana", "cherry"];

fruits.Add("date");
fruits.Remove("banana");
Console.WriteLine($"{string.Join(", ",fruits}")

