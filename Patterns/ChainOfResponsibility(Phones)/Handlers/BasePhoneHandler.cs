namespace ChainOfResponsibility_Phones_.Handlers
{
    internal abstract class BasePhoneHandler : IPhoneHandler
    {
        private IPhoneHandler nextHandler;
        public virtual void HandleRequest(string request)
        {
            if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
        public IPhoneHandler SetNext(IPhoneHandler handler)
        {
            nextHandler = handler;
            return handler;
        }
    }
}
