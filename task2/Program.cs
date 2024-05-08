static string lessThan100(int num1, int num2) {
    int result = num1 + num2;
    if (result < 100) {
        return $"The sum of {num1} and {num2} is less than 100";
    } else {
        return $"The sum of {num1} and {num2} is greater than 100";
    }
}

static string primeCheck(int num) {
    // base case a: numbers less that 1 are not prime
    if (num <= 1) {
        return $"{num} is not a prime";
    }
    // base case b: 2 and 3 are prime numbers
    if (num <= 3) {
        return $"{num} is a prime";
    }
    // square root of the number which is in double
    double numRoot = Math.Sqrt(num);
    int numRound = (int)numRoot;
    // iterate from 2 to the square root of the number
    for (int i = 2; i <= numRound + 1; i++)
     {
        //  Check if any of the modules is zero
        if (num % i == 0) {
            return $"{num} is not a prime"; 
        }
    }
    return $"{num} is a prime";
}
//test
Console.WriteLine(primeCheck(17));
Console.WriteLine(lessThan100(22,15));