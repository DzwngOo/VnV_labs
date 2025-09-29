namespace ICT3101_Calculator.UnitTests;

public class CalculatorTests
{
    private Calculator _calculator;
    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
    }
    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(10, 20);
        // Assert
        Assert.That(result, Is.EqualTo(30));
    }

    [Test]
    public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
    {
        double result = _calculator.Subtract(10, 5);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtract_WhenSubtractingNegativeNumber_ResultEqualToDifference()
    {
        double result = _calculator.Subtract(10, -5);
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
    {
        double result = _calculator.Multiply(4, 5);
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Multiply_WhenMultiplyingByZero_ResultEqualToZero()
    {
        double result = _calculator.Multiply(4, 0);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
    {
        double result = _calculator.Divide(20, 4);
        Assert.That(result, Is.EqualTo(5));
    }


    //Question 14 Test cases
    [Test]
    [TestCase(0, 0)]
    [TestCase(0, 10)]
    [TestCase(10, 0)]
    public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
    {
        Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
    }



    //Question 15 Test cases
    [Test]
    public void Factorial_OfZero_ReturnsOne()
    {
        double result = _calculator.Factorial(0);
        Assert.That(result, Is.EqualTo(1));  // 0! = 1
    }

    [Test]
    public void Factorial_OfPositiveInteger_ReturnsCorrectFactorial()
    {
        double result = _calculator.Factorial(5);
        Assert.That(result, Is.EqualTo(120));  // 5! = 120
    }

    [Test]
    public void Factorial_OfNegativeNumber_ThrowsArgumentException()
    {
        Assert.That(() => _calculator.Factorial(-1), Throws.ArgumentException);  // Negative numbers are invalid
    }

    [Test]
    public void Factorial_OfNonInteger_ThrowsArgumentException()
    {
        Assert.That(() => _calculator.Factorial(3.5), Throws.ArgumentException);  // Factorial is defined for integers only
    }




    //Question 16 Test cases
    [Test]
    public void AreaOfTriangle_ValidDimensions_CorrectArea()
    {
        double baseLength = 5;
        double height = 10;

        double actualArea = _calculator.AreaofTraiangle(height, baseLength);
        Assert.That(actualArea, Is.EqualTo(0.5 * baseLength * height));
    }

    [Test]
    public void AreaOfTriangle_NegativeDimensions_ThrowsArgumentException()
    {
        Assert.That(() => _calculator.AreaofTraiangle(-5, 10), Throws.ArgumentException);
        Assert.That(() => _calculator.AreaofTraiangle(5, -10), Throws.ArgumentException);
        Assert.That(() => _calculator.AreaofTraiangle(-5, -10), Throws.ArgumentException);
    }

    [Test]
    public void AreaOfCircle_ValidRadius_CorrectArea()
    {
        double radius = 7;
        double actualArea = _calculator.AreaofCircle(radius);
        Assert.That(actualArea, Is.EqualTo(Math.PI * radius * radius));
    }

    [Test]
    public void AreaOfCircle_NegativeRadius_ThrowsArgumentException()
    {
        Assert.That(() => _calculator.AreaofCircle(-7), Throws.ArgumentException);
    }





    // Question 17 Test case 
    [Test]
    public void UnknownFunctionA_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(60));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
    }
}