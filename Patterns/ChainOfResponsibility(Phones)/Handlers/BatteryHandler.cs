namespace ChainOfResponsibility_Phones_.Handlers
{
	internal class BatteryHandler : BasePhoneHandler
	{
		public override void HandleRequest(string request)
		{
			if (request == "battery")
			{
				Console.WriteLine("Battery level: 80%");
			}
			else
			{
				base.HandleRequest(request);
			}
		}
	}
}
