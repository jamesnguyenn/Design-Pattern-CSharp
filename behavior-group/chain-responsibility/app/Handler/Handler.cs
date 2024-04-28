public abstract class Handler
{
    private Handler next;
    public Handler setNextHandler(Handler next)
    {
        this.next = next;
        return next;
    }
    public abstract bool handle(string userName, string password, string role);
    protected bool handleNext(string userName, string password, string role)
    {
        if (next == null)
        {
            return true;
        }
        return next.handle(userName, password, role);
    }
}