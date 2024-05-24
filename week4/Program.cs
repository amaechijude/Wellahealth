//using MyName; 
using MyBank;

// Person tez = new();
// tez.Name = "Amaechi";
// var t = tez.Name;

Bank bal = new();
var a = bal.BankA = 200;
var b = bal.BankB = 300;
var c = bal.BankC = 500;

Console.WriteLine($"The sum of {a} was deposited in Bank A");
Console.WriteLine(b);
Console.WriteLine(c);

//buble sort

// int[] nums = {3, 4, 5, 6, 1, 2, 11, 19, 7, 10};
// Console.WriteLine("[" + string.Join(", ", nums) + "]");

// for (var i = 0; i < nums.Length; i++)
// {
//     for (var j = 0; j < nums.Length - 1; j++) {
//         if (nums[j] > nums[j + 1]) {
//             var temp = nums[j];
//             nums[j] = nums[j + 1];
//             nums[j + 1] = temp; 
//         }
//     }
// }

// Console.WriteLine("[" + string.Join(", ", nums) + "]");