using MementoDP;

var character = new GameCharacter(100, "Home");
var caretaker = new Caretaker();

character.Display();

caretaker.SaveState(character);

character.AddItem("Sword");
character.TakeDamage(20);
character.Move("Forest");

character.Display();

caretaker.SaveState(character);

character.AddItem("Shield");
character.TakeDamage(30);
character.Move("Cave");

character.Display();

caretaker.Undo(character);
character.Display();

caretaker.Undo(character);
character.Display();