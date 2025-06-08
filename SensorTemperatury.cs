using System.Dynamic;

public class SensorTemperatury
{
    private int aktualnaTemperatura;
    public int AktualnaTemperatura
    {
        get { return aktualnaTemperatura; }
        set
        {
            if (aktualnaTemperatura != value)
            {
                aktualnaTemperatura = value;
                OnZmianaTemperatury(new EventArgsZmianyTemperatury(aktualnaTemperatura));
            }
        }
    }
    private byte idSensora;
    public byte IdSensora
    {
        get{return idSensora; }
    }
    public SensorTemperatury(byte idSensora)
    {
        this.idSensora = idSensora;
    }

    public event DelegatZmianyTemperatury.ZmianaTemperatury ZmianaTemperatury;
    protected void OnZmianaTemperatury(EventArgsZmianyTemperatury e)
    {
        DelegatZmianyTemperatury.ZmianaTemperatury delegat = ZmianaTemperatury;
        if (delegat != null)
        {
            delegat.Invoke(this, e);
        }
    }
}