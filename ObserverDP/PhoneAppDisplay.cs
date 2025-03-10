namespace ObserverDP
{
	// Phone App Display
	public class PhoneAppDisplay : IObserver
	{
		public void Update(float temperature, float humidity, float pressure)
		{
			Console.WriteLine($"Phone App: Temperature = {temperature}°C, Humidity = {humidity}%, Pressure = {pressure}hPa");
		}
	}
}
