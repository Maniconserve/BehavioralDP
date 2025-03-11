namespace MementoDP
{
	public class CharacterMemento
	{
		public int Health { get; }
		public string Position { get; }
		public List<string> Inventory { get; }

		public CharacterMemento(int health, string position, List<string> inventory)
		{
			Health = health;
			Position = position;
			Inventory = new List<string>(inventory); 
		}
	}
}
