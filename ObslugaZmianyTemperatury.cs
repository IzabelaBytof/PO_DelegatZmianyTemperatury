public class ObslugaZmianyTemperatury
{
    private string nazwaObslugi;
    public ObslugaZmianyTemperatury(string nazwa)
    {
        nazwaObslugi = nazwa;
    }
    public void ObsluzZmianeTemperatury(object sender, EventArgsZmianyTemperatury e)
    {
        SensorTemperatury sensor = sender as SensorTemperatury;
        if (sensor != null)
        {
            Console.WriteLine($"[{nazwaObslugi}] Zmiana temperatury: {e.NowaTemperatura}°C, Sensor ID: {sensor.IdSensora}");
        }
    }
}