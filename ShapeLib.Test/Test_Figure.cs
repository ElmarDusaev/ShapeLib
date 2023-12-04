namespace ShapeLib.Test
{
    public class Test_Figure
    {

        
        /// <summary>
        /// Тестируем метод на прямоугольный труегольник
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        [Theory]
        [InlineData(5.0, 4.0, 3.0)]
        [InlineData(5.0, 12.0, 13.0)]
        [InlineData(15.0, 17.0, 8.0)]
        public void IdentifyTriangle_ShouldReturnRight(double a, double b, double c)
        {
            var result = Figure.IdentifyTriangle(a, b, c);
            Assert.Equal(TriangleType.RIGHT_TRIANGLE, result);
        }


        /// <summary>
        /// Тестируем метод на остроугольный труегольник
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        [Theory]
        [InlineData(5.0, 5.0, 5.0)]
        [InlineData(4.0, 4.0, 4.0)]
        [InlineData(3.0, 3.0, 3.0)]
        public void IdentifyTriangle_ShouldReturnAcute(double a, double b, double c)
        {
            var result = Figure.IdentifyTriangle(a, b, c);
            Assert.Equal(TriangleType.ACUTE_TRIANGLE, result);
        }

        /// <summary>
        /// Тестируем метод на тупоугольный труегольник
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        [Theory]
        [InlineData(6.0, 4.0, 9.0)]
        [InlineData(12.0, 8.0, 7.0)]
        public void IdentifyTriangle_ShouldReturnObtuse(double a, double b, double c)
        {
            var result = Figure.IdentifyTriangle(a, b, c);
            Assert.Equal(TriangleType.OBTUSE_TRIANGLE, result);
        }

        /// <summary>
        /// Тестируем метод на ошибку, передаем неправильные параметры (несуществующий треугольник) 
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        [Theory]
        [InlineData(10.0, 4.0, 3.0)]
        [InlineData(4.0, 10.0, 3.0)]
        [InlineData(3.0, 4.0, 10.0)]
        [InlineData(-3.0, -4.0, -10.0)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 0, 10)]
        [InlineData(3.0, 4.0, -5.0)]
        public void IdentifyTriangle_ShouldReturnArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => Figure.IdentifyTriangle(a, b, c));
        }


        /// <summary>
        /// Тестируем метод на ошибку, передаем максимальные значения 
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        [Theory]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)]
        public void IdentifyTriangle_ShouldReturnArithmeticException(double a, double b, double c)
        {
            Assert.Throws<ArithmeticException>(() => Figure.IdentifyTriangle(a, b, c));
        }
    }
}