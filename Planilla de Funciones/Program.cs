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