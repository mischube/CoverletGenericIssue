namespace CoverletGenericIssue;

public class Class1
{
    public object GetObject()
    {
        return new object();
    }

    public T GetObject<T>() where T : new()
    {
        return new T();
    }
}