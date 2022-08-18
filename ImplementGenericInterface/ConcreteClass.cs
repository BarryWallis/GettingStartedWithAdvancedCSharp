namespace ImplementGenericInterface;

internal class ConcreteClass<T> : IGenericInterface<T>
{
    public T GenericMethod(T param) => param;
    public void NonGenericMethod() => Console.WriteLine("Implementing NonGenericMethod of GenericInterface<T>");
}
