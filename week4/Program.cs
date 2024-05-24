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
//
public abstract class Bank
{
    public abstract double getBalance();
}

public class BankA : Bank
{
    private double balance = 100;

    public override double getBalance()
    {
        return balance;
    }
}

public class BankB : Bank
{
    private double balance = 150;

    public override double getBalance()
    {
        return balance;
    }
}

public class BankC : Bank
{
    private double balance = 200;

    public override double getBalance()
    {
        return balance;
    }
}

public class BankTest
{
    public static void Main(string[] args)
    {
        BankA bankA = new BankA();
        BankB bankB = new BankB();
        BankC bankC = new BankC();

        Console.WriteLine("Bank A Balance: $" + bankA.getBalance());
        Console.WriteLine("Bank B Balance: $" + bankB.getBalance());
        Console.WriteLine("Bank C Balance: $" + bankC.getBalance());
    }
}

