using ObserverPatternExample.Services;

var station = new WeatherStation();

var display = new TemperatureDisplay();
var logger = new TemperatureLogger();

station.Attach(display);
station.Attach(logger);

station.SetTemperature(25.3f);

station.SetTemperature(28.7f);
