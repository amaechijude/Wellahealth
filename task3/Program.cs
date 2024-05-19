// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

static string Remainder(int x, int y) {
    int result = x % y;

    return $"The remainder is {result}";
}

/*
Console.WriteLine("Enter the first number ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number ");
int y = Convert.ToInt32(Console.ReadLine());
*/

int x = 5;
int y = 2;

var output = Remainder(x, y);

Console.WriteLine(output);