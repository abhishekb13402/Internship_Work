using WebApplication1.Calc;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddTestSuccess()
        {
            //Arrange
            int expectedResult = 10;
            Calculator calculator = new Calculator();

            //Act
            int result = calculator.Add(4,6);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void AddMethodWithNegativeValue()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            //Assert
            Assert.Throws<Exception>(() => calculator.Add(3, -5));
        }

        [Fact]
        public void SubSuccess() 
        { 
            int expectedResult = 10;
            Calculator calculator = new Calculator();
            int result = calculator.Sub(20,10);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MulSuccess()
        {
            int expectedResult = 8;
            Calculator calculator = new Calculator();
            int result = calculator.Mul(2, 4);
            Assert.Equal(expectedResult, result);
        }

        //[Fact]
        //public void SubNum2IsGreater()
        //{
        //    int expectedResult = 10;
        //    Calculator calculator = new Calculator();
        //    int result = calculator.Sub(20,40);
        //    Assert.Equal(expectedResult, result);
        //}


        [Fact]
        public void DivTestSuccess()
        {
            //Arrange
            int expectedResult = 20;
            Calculator calculator = new Calculator();

            //Act
            int result = calculator.Div(100, 5);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void DivMethodWithZeroValue()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            //Assert
            Assert.Throws<Exception>(() => calculator.Div(10, 0));
        }

    }
}