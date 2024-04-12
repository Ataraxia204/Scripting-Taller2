using System;
using System.Text;

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


//Fuincion #13
string GenerateRandomPassword(int passwordLength)
{
    const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+={}[]|;':\"<,./?>~";
    StringBuilder passwordBuilder = new StringBuilder();
    Random random = new Random();

    for (int i = 0; i < passwordLength; i++)
    {
        int randomIndex = random.Next(0, allowedChars.Length);
        passwordBuilder.Append(allowedChars[randomIndex]);
    }

    return passwordBuilder.ToString();
}


//Fuincion #14
bool IsLeapYear(int year)
{
    if (year % 4 != 0)
    {
        return false;
    }
    else if (year % 100 == 0 && year % 400 != 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}


//Fuincion #15
int FactorialLoop(int number)
{
    if (number == 0)
    {
        return 1;
    }

    int result = 1;
    for (int i = number; i > 1; i--)
    {
        result *= i;
    }

    return result;
}

//Fuincion #16
string DecimalToBinary(int number)
{
    if (number == 0)
    {
        return "0";
    }

    string binaryString = "";
    while (number > 0)
    {
        int remainder = number % 2;
        binaryString = remainder + binaryString;
        number /= 2;
    }

    return binaryString;
}

//Fuincion #17
int GCDRecursive(int num1, int num2)
{
    if (num2 == 0)
    {
        return num1;
    }
    else
    {
        return GCDRecursive(num2, num1 % num2);
    }
}

//Fuincion #18
int[] FibonacciSequence(int n)
{
    if (n <= 1)
    {
        return new int[] { 0, 1 };
    }

    int[] fib = new int[n];
    fib[0] = 0;
    fib[1] = 1;

    for (int i = 2; i < n; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }

    return fib;
}

//Fuincion #19
bool IsPangram(string str)
{
    str = str.ToLower();
    HashSet<char> chars = new HashSet<char>();

    foreach (char c in str)
    {
        if (c >= 'a' && c <= 'z')
        {
            chars.Add(c);
        }
    }

    return chars.Count == 26;
}

//Fuincion #20
void ShuffleArray(int[] array)
{
    Random random = new Random();

    for (int i = array.Length - 1; i > 0; i--)
    {
        int j = random.Next(0, i + 1);
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

//Fuincion #21
bool EsFechaValida(int dia, int mes, int anio)
{
    try
    {
        DateTime fecha = new DateTime(anio, mes, dia);
        return true;
    }
    catch (Exception)
    {
        return false;
    }
}

//Fuincion #22
double CalcularVolumenEsfera(double radio)
{
    return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
}

//Fuincion #23
string InvertirCadena(string texto)
{
    char[] caracteres = texto.ToCharArray();
    Array.Reverse(caracteres);
    return new string(caracteres);
}

//Fuincion #24
int GenerarNumeroAleatorio(int min, int max)
{
    Random rand = new Random();
    return rand.Next(min, max + 1);
}

//Fuincion #25
int ContarVocales(string palabra)
{
    int contador = 0;
    foreach (char c in palabra.ToLower())
    {
        if ("aeiou".Contains(c))
            contador++;
    }
    return contador;
}


//Fuincion #26
string ConvertirAMayusculas(string texto)
{
    return texto.ToUpper();
}

//Fuincion #26
double CalcularPromedio(List<double> numeros)
{
    if (numeros.Count == 0)
        return 0;

    double suma = 0;
    foreach (var num in numeros)
    {
        suma += num;
    }
    return suma / numeros.Count;
}

//Fuincion #27
int Minimo(int a, int b)
{
    return a < b ? a : b;
}

//Fuincion #28
bool EsPrimo(int numero)
{
    if (numero <= 1)
        return false;

    for (int i = 2; i * i <= numero; i++)
    {
        if (numero % i == 0)
            return false;
    }
    return true;
}

//Fuincion #29
double CalcularAreaTriangulo(double baseTriangulo, double altura)
{
    return (baseTriangulo * altura) / 2;
}

//Fuincion #30

bool EsPalindromoSinEspacios(string palabra)
{
    palabra = palabra.ToLower().Replace(" ", "");
    return palabra == new string(palabra.Reverse().ToArray());
}
