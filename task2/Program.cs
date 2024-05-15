static string primeCheck(int num) {
    // base case a: numbers less that 1 are not prime
    if (num <= 1) {
        return $"{num} is not a prime number";
    }
    // base case b: 2 and 3 are prime numbers
    if (num <= 3) {
        return $"{num} is a prime number";
    }
    // square root of the number
    int numRound = (int)Math.Sqrt(num);
    // iterate from 2 to the square root of the number
    for (int i = 2; i <= numRound + 1; i++)
     {
        //  Check if any of the modules is zero
        if (num % i == 0) {
            return $"{num} is not a prime number"; 
        }
    }
    return $"{num} is a prime number";
}


static string lessThan100(int num1, int num2) {
    int result = num1 + num2;
    if (result < 100) {
        return $"true // {num1} + {num2} = {result}";
    } else {
        return $"false // {num1} + {num2} = {result}";
    }
}

//test

Console.WriteLine(primeCheck(17));
Console.WriteLine(lessThan100(83, 34));
