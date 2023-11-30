using System;

class Program
{
    public static void Main()
    {
        double result1 = MathOperations.Add(5.0, 3.0);
        double[] arrayResult = MathOperations.Add(new double[] { 1.0, 2.0, 3.0 }, new double[] { 4.0, 5.0, 6.0 });
        double[,] matrixResult = MathOperations.Multiply(new double[,] { { 1.0, 2.0 }, { 3.0, 4.0 } }, 2.0);

        double[] tensor1DResult = MathOperations.AddTensor(new double[] { 1.0, 2.0, 3.0 }, new double[] { 4.0, 5.0, 6.0 });
        double[,] tensor2DResult = MathOperations.MultiplyTensor(new double[,] { { 1.0, 2.0 }, { 3.0, 4.0 } }, 2.0);

        Console.WriteLine("Result of Add(5.0, 3.0): " + result1);

        Console.Write("Result of Add([1.0, 2.0, 3.0], [4.0, 5.0, 6.0]): ");
        foreach (var item in arrayResult)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Result of Multiply([[1.0, 2.0], [3.0, 4.0]], 2.0):");
        for (int i = 0; i < matrixResult.GetLength(0); i++)
        {
            for (int j = 0; j < matrixResult.GetLength(1); j++)
            {
                Console.Write(matrixResult[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.Write("Result of AddTensor([1.0, 2.0, 3.0], [4.0, 5.0, 6.0]): ");
        foreach (var item in tensor1DResult)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Result of MultiplyTensor([[1.0, 2.0], [3.0, 4.0]], 2.0):");
        for (int i = 0; i < tensor2DResult.GetLength(0); i++)
        {
            for (int j = 0; j < tensor2DResult.GetLength(1); j++)
            {
                Console.Write(tensor2DResult[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}