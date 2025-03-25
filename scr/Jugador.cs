namespace scr;

public abstract class Jugador
{
    public double VisionJuego { get; set; }
    public double VisionCompaneros { get; set; }
    public double Potencia { get; set; }
    public double HabilidadPases { get; set; }

    public abstract double GetPrecision();
    public abstract double GetVisionGeneral();
    
    public void AplicarEntrenamientoFisico()
    {
        Potencia += 1;
        HabilidadPases += 0.5;
    }
    
    public void AplicarEntrenamientoLirico()
    {
        HabilidadPases += 1;
        VisionJuego += 0.5;
    }
    
    public void AplicarEntrenamientoTactico()
    {
        VisionJuego += 0.5;
        VisionCompaneros += 0.5;
    }
}
