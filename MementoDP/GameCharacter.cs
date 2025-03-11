namespace MementoDP
{
	public class GameCharacter
	{
		public int Health { get; private set; }
		public string Position { get; private set; }
		public List<string> Inventory { get; private set; }

		public GameCharacter(int health, string position)
		{
			Health = health;
			Position = position;
			Inventory = new List<string>();
		}

		public void AddItem(string item)
		{
			Inventory.Add(item);
			Console.WriteLine($"Added {item} to inventory.");
		}

		public void TakeDamage(int damage)
		{
			Health -= damage;
			Console.WriteLine($"Took {damage} damage. Health is now {Health}.");
		}

		public void Move(string newPosition)
		{
			Position = newPosition;
			Console.WriteLine($"Moved to {newPosition}.");
		}

		public CharacterMemento Save()
		{
			Console.WriteLine("Saving character state...");
			return new CharacterMemento(Health, Position, Inventory);
		}

		public void Restore(CharacterMemento memento)
		{
			Health = memento.Health;
			Position = memento.Position;
			Inventory = new List<string>(memento.Inventory); Console.WriteLine("Character state restored.");
		}

		public void Display()
		{
			Console.WriteLine($"Health: {Health}, Position: {Position}, Inventory: [{string.Join(", ", Inventory)}]");
		}
	}
}
