namespace ChainOfResponsibility_Phones_
{
    public interface IPhoneHandler
    {
        void HandleRequest(string request);
        IPhoneHandler SetNext(IPhoneHandler handler);
    }
}
