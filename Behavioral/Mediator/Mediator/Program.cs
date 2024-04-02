using Mediator;

IChatRoom chatRoom = new ChatRoom();

// Create users
User user1 = new ChatUser(chatRoom);
User user2 = new ChatUser(chatRoom);
User user3 = new ChatUser(chatRoom);

// Register users in chat room
chatRoom.Register(user1);
chatRoom.Register(user2);
chatRoom.Register(user3);

// Send messages
user1.Send("Hello, world!");
user2.Send("Hi there!");