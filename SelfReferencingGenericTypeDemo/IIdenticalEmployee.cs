namespace SelfReferencingGenericTypeDemo;

internal interface IIdenticalEmployee<T>
{
    string CheckEqualityWith(T obj);
}
