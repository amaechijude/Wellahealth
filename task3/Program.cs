// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

static int Remainder(int x, int y) {
    int result = x % y;

    return result;
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

Console.WriteLine($"The rem of {x}/{y} --> {output}");