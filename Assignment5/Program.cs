namespace Assignment5;

class Program
{
    #region 1 - Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
    // when passing by value the original value won't be changed, but when passing by reference the original value will be changed.
    
    public static void PassByValue1(int num1)
    {
        num1 = 10;
        Console.WriteLine($"Inside Function num1: {num1}");
    }
    
    public static void PassByReference1(ref int num2)
    {
        num2 = 10;
        Console.WriteLine($"Inside Function num1: {num2}");
    }
    
    #endregion

    #region 2 - Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
    // when passing by value the original reference won't be changed, but when passing by reference the original reference will be changed.
    public static void PassByValue2(int[] arr)
    {
        arr[0] = 99;
        arr = new int[] { 7, 8, 9 };
    }
    
    public static void PassByReference2(ref int[] arr)
    {
        arr[0] = 99;
        arr = new int[] { 7, 8, 9 };
    }
    
    #endregion

    #region 3 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

    public static (int sum, int sub) SumSub(int num1, int num2, int num3, int num4)
    {
        int sum = num1 + num2;
        int sub = num3 - num4;
        return (sum, sub);
    }

    #endregion


    #region 4 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

    public static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }

    #endregion

    #region 5 - Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

    public static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    #endregion


    #region 6 - Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

    public static (int min, int max) MinMaxArray(ref int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }

            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return (min, max);
    }

    #endregion

    #region 7 - Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

    public static int Factorial(int num)
    {
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }

        return fact;
    }

    #endregion


    #region 8 - Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

    public static string ChangeChar(string str, int index, char newChar)
    {
        char[] charArray = str.ToCharArray();
        charArray[index] = newChar;
        return new string(charArray);
    }

    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine("Q1 pass by value Demonstration:");
        int num1 = 5;
        Console.WriteLine($"num1 before passing by value: {num1}");
        PassByValue1(num1);
        Console.WriteLine($"num1 after passing by value: {num1}");
        
        Console.WriteLine("Q1 pass by reference Demonstration:");
        int num2 = 5;
        Console.WriteLine($"num2 before passing by reference: {num2}");
        PassByReference1(ref num2);
        Console.WriteLine($"num2 after passing by reference: {num2}");
        
        
        Console.WriteLine("Q2 pass by value Demonstration:");
        int[] array1 = { 1, 2, 3 };
        Console.WriteLine("array before passing by value: " + string.Join(", ", array1));
        PassByValue2(array1);
        Console.WriteLine("array after passing by value: " + string.Join(", ", array1));
        
        Console.WriteLine("Q2 pass by reference Demonstration:");
        int[] array2 = { 1, 2, 3 };
        Console.WriteLine("array before passing by reference: " + string.Join(", ", array2));
        PassByReference2(ref array2);
        Console.WriteLine("array after passing by reference: " + string.Join(", ", array2));
        
        Console.WriteLine(SumSub(1, 2, 3, 4));

        Console.WriteLine(SumOfDigits(25));

        Console.WriteLine(IsPrime(7));

        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(MinMaxArray(ref arr));

        Console.WriteLine(Factorial(5));

        Console.WriteLine(ChangeChar("Hello", 1, 'a'));
    }
}