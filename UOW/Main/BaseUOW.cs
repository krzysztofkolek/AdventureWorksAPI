namespace AdventureWorks.UOW.Main
{
    public abstract class BaseUOW<T>
        where T : class, new()
    {
        public abstract T GetResult();
    }
}