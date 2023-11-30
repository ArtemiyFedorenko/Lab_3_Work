class MathOperations
{
    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;

    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new ArgumentException("Cannot divide by zero");

        return a / b;
    }

    public static double[] Add(double[] arr1, double[] arr2)
    {
        if (arr1.Length != arr2.Length)
            throw new ArgumentException("Arrays must be of the same length");

        double[] result = new double[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }

        return result;
    }

    public static double[] Subtract(double[] arr1, double[] arr2)
    {
        if (arr1.Length != arr2.Length)
            throw new ArgumentException("Arrays must be of the same length");

        double[] result = new double[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] - arr2[i];
        }

        return result;
    }

    public static double[] Multiply(double[] arr, double scalar)
    {
        double[] result = new double[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[i] * scalar;
        }

        return result;
    }

    public static double[] Divide(double[] arr, double divisor)
    {
        if (divisor == 0)
            throw new ArgumentException("Cannot divide by zero");

        double[] result = new double[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[i] / divisor;
        }

        return result;
    }

    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
            throw new ArgumentException("Matrices must have the same dimensions");

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    public static double[,] Subtract(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
            throw new ArgumentException("Matrices must have the same dimensions");

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    public static double[,] Multiply(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }

    public static double[,] Divide(double[,] matrix, double divisor)
    {
        if (divisor == 0)
            throw new ArgumentException("Cannot divide by zero");

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] / divisor;
            }
        }

        return result;
    }

    public static double[] AddTensor(double[] tensor1, double[] tensor2)
    {
        if (tensor1.Length != tensor2.Length)
            throw new ArgumentException("Tensors must have the same length");

        double[] result = new double[tensor1.Length];
        for (int i = 0; i < tensor1.Length; i++)
        {
            result[i] = tensor1[i] + tensor2[i];
        }

        return result;
    }

    public static double[] SubtractTensor(double[] tensor1, double[] tensor2)
    {
        if (tensor1.Length != tensor2.Length)
            throw new ArgumentException("Tensors must have the same length");

        double[] result = new double[tensor1.Length];
        for (int i = 0; i < tensor1.Length; i++)
        {
            result[i] = tensor1[i] - tensor2[i];
        }

        return result;
    }

    public static double[] MultiplyTensor(double[] tensor, double scalar)
    {
        double[] result = new double[tensor.Length];
        for (int i = 0; i < tensor.Length; i++)
        {
            result[i] = tensor[i] * scalar;
        }

        return result;
    }

    public static double[] DivideTensor(double[] tensor, double divisor)
    {
        if (divisor == 0)
            throw new ArgumentException("Cannot divide by zero");

        double[] result = new double[tensor.Length];
        for (int i = 0; i < tensor.Length; i++)
        {
            result[i] = tensor[i] / divisor;
        }

        return result;
    }

    public static double[,] AddTensor(double[,] tensor1, double[,] tensor2)
    {
        int rows = tensor1.GetLength(0);
        int cols = tensor1.GetLength(1);

        if (rows != tensor2.GetLength(0) || cols != tensor2.GetLength(1))
            throw new ArgumentException("Tensors must have the same dimensions");

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = tensor1[i, j] + tensor2[i, j];
            }
        }

        return result;
    }

    public static double[,] SubtractTensor(double[,] tensor1, double[,] tensor2)
    {
        int rows = tensor1.GetLength(0);
        int cols = tensor1.GetLength(1);

        if (rows != tensor2.GetLength(0) || cols != tensor2.GetLength(1))
            throw new ArgumentException("Tensors must have the same dimensions");

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = tensor1[i, j] - tensor2[i, j];
            }
        }

        return result;
    }

    public static double[,] MultiplyTensor(double[,] tensor, double scalar)
    {
        int rows = tensor.GetLength(0);
        int cols = tensor.GetLength(1);

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = tensor[i, j] * scalar;
            }
        }

        return result;
    }

    public static double[,] DivideTensor(double[,] tensor, double divisor)
    {
        if (divisor == 0)
            throw new ArgumentException("Cannot divide by zero");

        int rows = tensor.GetLength(0);
        int cols = tensor.GetLength(1);

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = tensor[i, j] / divisor;
            }
        }

        return result;
    }

}