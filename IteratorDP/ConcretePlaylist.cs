namespace IteratorDP
{
	public class ConcretePlaylist : IPlaylist
	{
		private List<Song> _songs = new List<Song>();

		public void AddSong(Song song)
		{
			_songs.Add(song);
		}

		public IIterator CreateIterator()
		{
			return new PlaylistIterator(this);
		}

		public int Count => _songs.Count;

		public Song this[int index] => _songs[index];
	}
}
