namespace Test123.Test1.UI
{
    public interface IViewModel<out TData>
    {
        TData Data { get; }
    }
}