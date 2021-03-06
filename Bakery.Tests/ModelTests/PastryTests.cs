using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2.99);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPrice_Double()
    {
      double price = 2.99;
      Pastry newPastry = new Pastry(price);

      double result = newPastry.PastryPrice;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPastryPrice_SetPastryPrice_Double()
    {
      double price = 2.99;
      Pastry newPastry = new Pastry(price);

      double updatedPrice = 1.99;
      newPastry.PastryPrice = updatedPrice;
      double result = newPastry.PastryPrice;

      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnPastryCost_Double()
    {
      double price = 2.99;
      Pastry newPastry = new Pastry(price);
      int amount = 3;

      double result = newPastry.CalculatePastryCost(amount);

      Assert.AreEqual(amount * price, result);
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryWithDealMarker_Pastry()
    {
      double price = 2.99;
      Pastry newPastry = new Pastry(price, true);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CalculatePastryCostIfDeal_ReturnPastryCostWithDiscount_Double()
    {
      int amount = 7;
      double price = 2;
      Pastry newPastry = new Pastry(price, true);

      double result = newPastry.CalculatePastryCost(amount);

      Assert.AreEqual((amount / 3) * (price - 1) + (amount - amount / 3) * price, result);
    }
  }
}