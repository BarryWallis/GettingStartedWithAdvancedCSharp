namespace ImplementGenericInterface;

internal interface IGenericInterface<T>
{
    T GenericMethod(T param);
    public void NonGenericMethod();
}
