using System;

class Task1s
{
    static void Main()
    {
        int[] A = new int[5];
        double[,] B = new double[3, 4];

        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            A[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = random.Next(-100, 101);
            }
        }

        Console.WriteLine("Array A:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + " ");
        }

        Console.WriteLine("\nArray B:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

        double max = A[0];
        double min = A[0];
        double sum = 0;
        double product = 1;
        int evenSum = 0;
        double oddColumnsSum = 0;

        for (int i = 0; i < 5; i++)
        {
            if (A[i] > max) max = A[i];
            if (A[i] < min) min = A[i];

            sum += A[i];
            product *= A[i];

            if (A[i] % 2 == 0)
                evenSum += A[i];
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (B[i, j] > max) max = B[i, j];
                if (B[i, j] < min) min = B[i, j];

                sum += B[i, j];
                product *= B[i, j];

                if (j % 2 == 0)
                    oddColumnsSum += B[i, j];
            }
        }

        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Even elements sum of A: " + evenSum);
        Console.WriteLine("Odd columns sum of B: " + oddColumnsSum);
    }
}

class Task2
{
    static void Main()
    {
        int[,] A = new int[5, 5];
        Random random = new Random();

        int min = 100;
        int max = -100;
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                A[i, j] = random.Next(-100, 101);
                Console.Write(A[i, j] + "\t");

                int index = i * 5 + j;

                if (A[i, j] < min)
                {
                    min = A[i, j];
                    minIndex = index;
                }

                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxIndex = index;
                }
            }
            Console.WriteLine();
        }

        int start = Math.Min(minIndex, maxIndex);
        int end = Math.Max(minIndex, maxIndex);
        int sum = 0;

        int count = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int index = i * 5 + j;

                if (index > start && index < end)
                {
                    sum += A[i, j];
                    count++;
                }
            }
        }

        Console.WriteLine("Sum: " + sum);
    }
}

class Task3
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter shift: ");
        int shift = Convert.ToInt32(Console.ReadLine());

        string encrypted = "";

        foreach (char c in text)
        {
            if (c >= 'a' && c <= 'z')
                encrypted += (char)('a' + (c - 'a' + shift % 26 + 26) % 26);
            else if (c >= 'A' && c <= 'Z')
                encrypted += (char)('A' + (c - 'A' + shift % 26 + 26) % 26);
            else
                encrypted += c;
        }

        Console.WriteLine("Encrypted: " + encrypted);

        string decrypted = "";

        foreach (char c in encrypted)
        {
            if (c >= 'a' && c <= 'z')
                decrypted += (char)('a' + (c - 'a' - shift % 26 + 26) % 26);
            else if (c >= 'A' && c <= 'Z')
                decrypted += (char)('A' + (c - 'A' - shift % 26 + 26) % 26);
            else
                decrypted += c;
        }

        Console.WriteLine("Decrypted: " + decrypted);
    }
}

class Task4
{
    static void Main()
    {
        Console.WriteLine("1 - Multiply matrix by number");
        Console.WriteLine("2 - Add matrices");
        Console.WriteLine("3 - Multiply matrices");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            int[,] A = new int[2, 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    A[i, j] = Convert.ToInt32(Console.ReadLine());

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(A[i, j] * number + "\t");
                }
                Console.WriteLine();
            }
        }
        else if (choice == 2)
        {
            int[,] A = new int[2, 2];
            int[,] B = new int[2, 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    A[i, j] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    B[i, j] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(A[i, j] + B[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        else if (choice == 3)
        {
            int[,] A = new int[2, 2];
            int[,] B = new int[2, 2];
            int[,] C = new int[2, 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    A[i, j] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    B[i, j] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }

                    Console.Write(C[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

class Task5
{
    static void Main()
    {
        Console.Write("Enter expression: ");
        string expression = Console.ReadLine();

        string[] numbers = expression.Split('+', '-');

        int result = Convert.ToInt32(numbers[0]);
        int index = numbers[0].Length;

        for (int i = 1; i < numbers.Length; i++)
        {
            char operation = expression[index];

            if (operation == '+')
                result += Convert.ToInt32(numbers[i]);
            else
                result -= Convert.ToInt32(numbers[i]);

            index += numbers[i].Length + 1;
        }

        Console.WriteLine(result);
    }
}