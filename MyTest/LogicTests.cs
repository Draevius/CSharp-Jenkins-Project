using Xunit;
using HelloWorldApp;
namespace MyTests;
public class LogicTests {
    [Fact]
    public void TestMultiplication() {
        var logic = new BusinessLogic();
        Assert.Equal(25, logic.Multiply(5, 5));
    }
}
