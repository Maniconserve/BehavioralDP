//namespace MediatorDP
//{
//	public class User
//	{
//		public string Name { get; }

//		public User(string name)
//		{
//			Name = name;
//		}

//		public void SendMessage(string message, User recipient)
//		{
//			Console.WriteLine($"{Name} sends: {message}");
//			recipient.ReceiveMessage(message, this);
//		}

//		public void ReceiveMessage(string message, User sender)
//		{
//			Console.WriteLine($"{Name} receives from {sender.Name}: {message}");
//		}
////		Problems with This Approach:
//		//Tight Coupling:

//		//Each User object needs to know about other User objects to send messages.

//		//Scalability Issues:

//		//Adding new users or features(e.g., group chats) becomes difficult.

//		//Violation of Single Responsibility Principle:

//		//The User class is responsible for both sending and receiving messages.

//		//Hard to Test:

//		//Testing the User class requires mocking or creating multiple User objects.
//	}
//}
