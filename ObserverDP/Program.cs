// Create the Weather Station (Subject)
using ObserverDP;

WeatherStation weatherStation = new WeatherStation();

// Create the Observers (Display Devices)
var phoneApp = new PhoneAppDisplay();
var webDashboard = new WebDashboardDisplay();
var physicalDisplay = new PhysicalDisplay();

// Register Observers with the Subject
weatherStation.RegisterObserver(phoneApp);
weatherStation.RegisterObserver(webDashboard);
weatherStation.RegisterObserver(physicalDisplay);

// Simulate weather data changes
weatherStation.SetMeasurements(25.0f, 65.0f, 1013.0f);
Console.WriteLine();

weatherStation.SetMeasurements(26.5f, 70.0f, 1012.0f);
Console.WriteLine();

// Remove an Observer (e.g., physical display)
weatherStation.RemoveObserver(physicalDisplay);

// Simulate another weather data change
weatherStation.SetMeasurements(27.0f, 68.0f, 1011.0f);