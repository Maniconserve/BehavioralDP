using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
	public interface IChatRoomMediator
	{
		void SendMessage(string message, User sender);
		void AddUser(User user);
	}
}
