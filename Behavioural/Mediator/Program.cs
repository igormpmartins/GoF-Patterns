using Mediator;

var tom = new Visitor("Tom");
var dick = new Visitor("Dick");
var harry = new Visitor("Harry");

var chatroom = new Chatroom();
tom.Enter(chatroom);
dick.Enter(chatroom);
harry.Enter(chatroom);

tom.Send("Yo guys");
dick.Send("Ó bátima");
harry.Send("Ae Tom, nice 2 mit ya");

