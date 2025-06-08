public class EventArgsZmianyTemperatury : EventArgs
{
    private int nowaTemperatura;
    public int NowaTemperatura
    {
        get { return nowaTemperatura; }
    }
    public EventArgsZmianyTemperatury(int nowaTemperatura)
    {
        this.nowaTemperatura = nowaTemperatura;
    }
}