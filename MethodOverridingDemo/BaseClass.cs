namespace MethodOverridingDemo;

internal class BaseClass<T>
{
    public virtual T MyMethod(T parameter)
    {
        Console.WriteLine("Inside BaseClass.BaseMethod().");
        return parameter;
    }
}
