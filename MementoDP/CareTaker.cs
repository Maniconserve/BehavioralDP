namespace MementoDP
{
	public class Caretaker
	{
		private readonly Stack<CharacterMemento> _mementos = new Stack<CharacterMemento>();

		public void SaveState(GameCharacter character)
		{
			_mementos.Push(character.Save());
		}

		public void Undo(GameCharacter character)
		{
			if (_mementos.Count > 0)
			{
				character.Restore(_mementos.Pop());
			}
			else
			{
				Console.WriteLine("No more states to undo.");
			}
		}
	}
}
