class Program
{
    static void Main()
    {
        Quaternion quat1 = new Quaternion(6, 3, 6, 1);
        Quaternion quat2 = new Quaternion(3, 5, 6, 7);

        PrintQuaternion("Quaternion 1", quat1);
        PrintQuaternion("Quaternion 2", quat2);

        PerformOperation("Sum", quat1 + quat2);
        PerformOperation("Difference", quat1 - quat2);
        PerformOperation("Product", quat1 * quat2);

        PrintResult("Norm of Quaternion 1", quat1.Norm());
        PrintQuaternion("Conjugate of Quaternion 1", quat1.Conjugate());
        PrintQuaternion("Inverse of Quaternion 1", quat1.Inverse());

        CheckEquality("Equality", quat1 == quat2);
        CheckEquality("Inequality", quat1 != quat2);

        PrintMatrix("Rotation Matrix", quat1.ToRotationMatrix());
    }

    static void PrintQuaternion(string label, Quaternion quaternion)
    {
        Console.WriteLine($"{label}: {quaternion}\n");
    }

    static void PerformOperation(string operation, Quaternion result)
    {
        Console.WriteLine($"{operation}: {result}");
    }

    static void PrintResult(string label, double result)
    {
        Console.WriteLine($"{label}: {result}\n");
    }

    static void CheckEquality(string comparison, bool result)
    {
        Console.WriteLine($"Quaternion 1 {comparison} Quaternion 2: {result}\n");
    }

    static void PrintMatrix(string label, double[,] matrix)
    {
        Console.WriteLine($"{label}:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matrix[i, j],-8}");
            }
            Console.WriteLine();
        }
    }
}