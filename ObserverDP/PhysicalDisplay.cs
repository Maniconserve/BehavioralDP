namespace ObserverDP
{
	// Physical Display
	public class PhysicalDisplay : IObserver
	{
		public void Update(float temperature, float humidity, float pressure)
		{
			Console.WriteLine($"Physical Display: Temperature = {temperature}°C, Humidity = {humidity}%, Pressure = {pressure}hPa");
		}
	}
}
