namespace LuanvanCTUET.Data.Interface
{
    public interface IHasOwner<T>
    {
        T OwnerId { get; set; }
    }
}