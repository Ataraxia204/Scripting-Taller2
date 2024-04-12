using System;

//Fuincion #1
int AddNumbers(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}

//Fuincion #2
int result = AddNumbers(5, 3);
Console.WriteLine(result);

//Fuincion #3
string CombineNames(string firstName, string lastName)
{
    return firstName + " " + lastName;
    
}

//Fuincion #4
bool IsEven(int number)
{
    return number % 2 == 0;
}

//Fuincion #5
double GetRectangleArea(double length, double width)
{
    return length * width;
}

//Fuincion #6
int FindLargest(int num1, int num2, int num3)
{
    int largest = num1;
    if (num2 > largest) largest = num2;
    if (num3 > largest) largest = num3;
    return largest;
}

//Fuincion #7
double CelsiusToFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

//Fuincion #8
void PrintWelcomeMessage()
{
    Console.WriteLine("Welcome to the program!");
}


//Fuincion #9
bool IsStringEmpty(string text)
{
    return string.IsNullOrEmpty(text);
}

//Fuincion #10
string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

//Fuincion #11
int Factorial(int number)
{
    if (number == 0) return 1;
    return number * Factorial(number - 1);
}

//Fuincion #12
double GetAverage(int[] numbers)
{
    if (numbers.Length == 0) return 0;
    double sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }
    return sum / numbers.Length;
}
