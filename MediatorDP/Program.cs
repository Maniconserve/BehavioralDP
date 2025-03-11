// Create mediator
using MediatorDP;

IChatRoomMediator chatRoom = new ChatRoom();

// Create users
var mani = new User("Mani", chatRoom);
var venky = new User("Venky", chatRoom);
var sampath = new User("Sampath", chatRoom);

// Add users to the chat room
chatRoom.AddUser(mani);
chatRoom.AddUser(venky);
chatRoom.AddUser(sampath);

// Users send messages
mani.SendMessage("Hi everyone!");
venky.SendMessage("Hello Sampath!");
sampath.SendMessage("Hey Venky!");