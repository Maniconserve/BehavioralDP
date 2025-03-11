namespace MediatorDP
{
	// Concrete mediator
	public class ChatRoom : IChatRoomMediator
	{
		private readonly List<User> _users = new List<User>();

		public void AddUser(User user)
		{
			_users.Add(user);
		}

		public void SendMessage(string message, User sender)
		{
			foreach (var user in _users)
			{
				// Don't send the message back to the sender
				if (user != sender)
				{
					user.ReceiveMessage(message);
				}
			}
		}
	}
}
