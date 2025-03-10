namespace ObserverDP
{
	// Web Dashboard Display
	public class WebDashboardDisplay : IObserver
	{
		public void Update(float temperature, float humidity, float pressure)
		{
			Console.WriteLine($"Web Dashboard: Temperature = {temperature}°C, Humidity = {humidity}%, Pressure = {pressure}hPa");
		}
	}
}
