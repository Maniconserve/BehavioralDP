namespace IteratorDP
{
	public class PlaylistIterator : IIterator
	{
		private readonly ConcretePlaylist _playlist;
		private int _index = 0;

		public PlaylistIterator(ConcretePlaylist playlist)
		{
			_playlist = playlist;
		}

		public bool HasNext()
		{
			return _index < _playlist.Count;
		}

		public Song Next()
		{
			if (HasNext())
			{
				return _playlist[_index++];
			}
			else
			{
				throw new InvalidOperationException("No more songs in the playlist.");
			}
		}
	}
}
