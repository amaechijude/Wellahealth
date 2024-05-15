// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to Remainder checker. Press Enter to continue ");
Console.ReadLine();

static string Remainder(int x, int y) {
    int result = x % y;

    return $"The remainder is {result}";
}

Console.WriteLine("Enter the first number ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number ");
int y = Convert.ToInt32(Console.ReadLine());

var output = Remainder(x, y);

Console.WriteLine(output);