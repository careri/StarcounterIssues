namespace Test.API

{
    public interface IPersistent
    {
    }

    public interface IPersistent<TSelf> : IPersistent
        where TSelf : IPersistent<TSelf>
    {
    }
}