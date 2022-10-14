namespace TDD;

[TestFixture]
public class Tests
{
   
    Maths operation =null;
    Maths operation2=null;
    Maths operation3=null;

     [SetUp]
    public void Setup()
    {
        operation=new Maths();
        operation2=new Maths();
        operation3=new Maths();
    }

    [Test]
    public void Test1()
    {
        int result=operation.Addition(10,11);
        Assert.That(result,Is.EqualTo(21));
    }
   // [TestCase("hello","world","hi")]
    [TestCase(2.3,4.5,5.5)]
    public void IsAdditionOk(dynamic value1, dynamic value2,dynamic value3)
    {
        dynamic output=operation.Addition(value1,value2);
        Assert.AreEqual(output,6.8);
    }
}