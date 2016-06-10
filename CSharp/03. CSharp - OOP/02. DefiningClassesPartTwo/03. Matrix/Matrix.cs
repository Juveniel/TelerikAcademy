namespace _03.Matrix
{
    using System;
    using System.Text;

    public class Matrix<T> where T : IComparable
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rows cannot be null");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cols cannot be null");
                }

                this.cols = value;
            }
        }

        public T this[int rows, int cols]
        {
            get
            {
                return this.matrix[rows, cols];
            }

            set
            {
                this.matrix[rows, cols] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0) ||
                secondMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrices are with different dimensions!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < secondMatrix.Cols; col++)
                {
                    try
                    {
                        resultMatrix[row, col] = (dynamic)firstMatrix[row, col] + (dynamic)secondMatrix[row, col];
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to sum: " + ex.Message);
                    }
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0) ||
                secondMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrices are with different dimensions!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < secondMatrix.Cols; col++)
                {
                    try
                    {
                        resultMatrix[row, col] = (dynamic)firstMatrix[row, col] - (dynamic)secondMatrix[row, col];
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to substract: " + ex.Message);
                    }
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0) ||
               secondMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrices are with different dimensions!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < secondMatrix.Cols; col++)
                {
                    for (int k = 0; k < firstMatrix.Cols; k++)
                    {
                        try
                        {
                            resultMatrix[row, col] = (dynamic)firstMatrix[row, col] * (dynamic)secondMatrix[row, col];
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Unable to multiply: " + ex.Message);
                        }
                    }                   
                }
            }

            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool isTrue = true;

            if (matrix != null && matrix.Rows > 0 && matrix.Cols > 0)
            {
                for (int row = 0; row < matrix.Rows; row++)
                {
                    for (int col = 0; col < matrix.Cols; col++)
                    {
                        if ((dynamic)matrix[row, col] == 0)
                        {
                            isTrue = false;
                        }
                    }
                }
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isFalse = false;

            if (matrix != null && matrix.Rows > 0 && matrix.Cols > 0)
            {
                for (int row = 0; row < matrix.Rows; row++)
                {
                    for (int col = 0; col < matrix.Cols; col++)
                    {
                        if ((dynamic)matrix[row, col] == 0)
                        {
                            isFalse = true;
                        }
                    }
                }
            }
            else
            {
                isFalse = true;
            }

            return isFalse;
        }

        public override string ToString()
        {
            StringBuilder endString = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    endString.AppendFormat("{0, 3}", this[i, j]);
                }

                endString.AppendLine();
            }

            return endString.ToString();
        }
    }
}
