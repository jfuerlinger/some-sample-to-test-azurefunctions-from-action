using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeSample.Core;

namespace SomeSample.Test
{
  [TestClass]
  public class CalculatorTests
  {
    [TestMethod]
    public void Add_CallWith3And5_ShouldReturn8()
    {
      // Arrange

      // Act
      int actual = Calculator.Add(3, 5);

      // Assert
      Assert.AreEqual(8, actual);
    }

    [TestMethod]
    public void Add_CallWith0And0_ShouldReturn0()
    {
      // Arrange

      // Act
      int actual = Calculator.Add(0, 0);

      // Assert
      Assert.AreEqual(0, actual);
    }
  }
}
