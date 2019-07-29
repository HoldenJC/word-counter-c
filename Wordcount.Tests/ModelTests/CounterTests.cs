using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordcounter.Models;

namespace Wordcounter.Tests
{

  [TestClass]
  public class CounterTests
  {

    [TestMethod]
    public void Word_DoesNotAppear_0()
    {
      Counter testCounter = new Counter("dog", "I am cat.");
      int result = testCounter.findWord();
      Assert.AreEqual(result, 0);
    }

    [TestMethod]
    public void Word_DoesAppear_1()
    {
      Counter testCounter = new Counter("dog", "I am dog.");
      int result = testCounter.findWord();
      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void Word_DoesAppearMultiple_2()
    {
      Counter testCounter = new Counter("dog", "I am dog, hear dog roar.");
      int result = testCounter.findWord();
      Assert.AreEqual(result, 2);
    }

    [TestMethod]
    public void Word_AppearsButNotFullMatch_0()
    {
      Counter testCounter = new Counter("dog", "I am doggo.");
      int result = testCounter.findWord();
      Assert.AreEqual(result, 0);
    }
  }
}