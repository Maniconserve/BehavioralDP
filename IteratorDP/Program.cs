using IteratorDP;

var playlist = new ConcretePlaylist();
playlist.AddSong(new Song("Musire Mabbula", "Sirivennela Seetharama sastry"));
playlist.AddSong(new Song("Neeli Meghamulalo", "Bharadwaj Gali"));
playlist.AddSong(new Song("C/O Kancharamapalem", "Viswha"));

IIterator iterator = playlist.CreateIterator();

while (iterator.HasNext())
{
	Song song = iterator.Next();
	Console.WriteLine(song);
}