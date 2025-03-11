namespace MediatorDP
{
	public class User
	{
		public string Name { get; }
		private readonly IChatRoomMediator _mediator;

		public User(string name, IChatRoomMediator mediator)
		{
			Name = name;
			_mediator = mediator;
		}

		public void SendMessage(string message)
		{
			Console.WriteLine($"{Name} sends: {message}");
			_mediator.SendMessage(message, this);
		}

		public void ReceiveMessage(string message)
		{
			Console.WriteLine($"{Name} receives: {message}");
		}
	}
}
