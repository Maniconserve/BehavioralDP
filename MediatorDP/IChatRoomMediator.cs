namespace MediatorDP
{
	public interface IChatRoomMediator
	{
		void SendMessage(string message, User sender);
		void AddUser(User user);
	}
}
