namespace AdventureWorks.UOW.Builder
{
    public abstract class Builder<T> 
        where T: class
    {
        public abstract T Build();
    }
}
