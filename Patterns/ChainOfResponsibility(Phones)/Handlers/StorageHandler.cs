namespace ChainOfResponsibility_Phones_.Handlers
{
    internal class StorageHandler : BasePhoneHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "storage")
            {
                Console.WriteLine("Available storage: 64GB");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
