namespace CoverletGenericIssue.Test;

public class Tests
{
    [Test]
    public void GetObject_Regular_NotNull()
    {
        var class1 = new Class1();

        var obj = class1.GetObject();

        Assert.That(obj, Is.Not.Null);
    }

    [Test]
    public void GetObject_Generic_NotNull()
    {
        var class1 = new Class1();

        var obj = class1.GetObject<Class1>();

        Assert.That(obj, Is.Not.Null);
        Assert.That(obj, Is.TypeOf<Class1>());
    }
}