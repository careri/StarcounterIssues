namespace Test.API
{
    public interface IUser : IPersistent<IUser>
    {
        string Name { get; set; }
    }
}