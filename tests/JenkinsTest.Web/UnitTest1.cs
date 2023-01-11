namespace JenkinsTest.Web;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine("Test 1 info");
        Assert.Pass();
    }

    [Test]
    public void Test2()
    {
        throw new Exception("Some unexpected exception");
    }
}