namespace MatrixTests
{
    using System;
    using NUnit.Framework;   
    using Matrix.Models;

    public class MatrixTests
    {
        [Test]
        public void NewMatrix_ShouldCraeteAnInstanceOfMatrix()
        {
            const int matrixSize = 4;

            var matrix = new Matrixx(matrixSize);

            Assert.IsInstanceOf<Matrixx>(matrix);
            Assert.IsTrue(matrix.Size == matrixSize);
        }

        [Test]
        public void SizeBellowOrEqualToZero_ShoulThrowAnArgumentOutOfRangeException()
        {
            const int matrixSize = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Matrixx(matrixSize));
        }

        [Test]
        public void SizeOver100_ShoulThrowAnArgumentOutOfRangeException()
        {
            const int matrixSize = 101;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Matrixx(matrixSize));
        }    
    }
}
