namespace MethodOverridingDemo;

internal class DerivedClass<T> : BaseClass<T>
{
    public override T MyMethod(T parameter)
    {
        Console.WriteLine("Here I am inside of DerivedClass.MyMethod().");
        return parameter;
    }
}
