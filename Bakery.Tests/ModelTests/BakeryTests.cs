using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_ReturnsCount_Int()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(2, newBread.Count);
    }

    [TestMethod]
    public void BreadSetter_AllowsChangeToCount_Int()
    {
      Bread newBread = new Bread(2);
      newBread.Count += 1;
      Assert.AreEqual(3, newBread.Count);
    }

    [TestMethod]
    public void Cost_ReturnsPriceOfBreadOrder_Int()
    {
      Bread order1 = new Bread(1);
      Bread order2 = new Bread(2);
      Bread order3 = new Bread(3);
      Bread order4 = new Bread(4);
      Assert.AreEqual(5, order1.Cost());
      Assert.AreEqual(10, order2.Cost());
      Assert.AreEqual(10, order3.Cost());
      Assert.AreEqual(15, order4.Cost());
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryGetter_ReturnsCount_Int()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(2, newPastry.Count);
    }

    [TestMethod]
    public void PastrySetter_AllowsChangeToCount_Int()
    {
      Pastry newPastry = new Pastry(2);
      newPastry.Count -= 1;
      Assert.AreEqual(1, newPastry.Count);
    }

    [TestMethod]
    public void Cost_ReturnsPriceOfPastryOrder_Int()
    {
      Pastry order1 = new Pastry(1);
      Pastry order2 = new Pastry(2);
      Pastry order3 = new Pastry(3);
      Pastry order4 = new Pastry(4);
      Assert.AreEqual(2, order1.Cost());
      Assert.AreEqual(4, order2.Cost());
      Assert.AreEqual(5, order3.Cost());
      Assert.AreEqual(7, order4.Cost());
    }
  }
}