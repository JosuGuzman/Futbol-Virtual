namespace scr;

public class Atacante : Jugador
{
    public double Anotacion { get; set; }

    public override double GetPrecision() => Anotacion;

    public override double GetVisionGeneral() => VisionJuego + HabilidadPases;
    
    public new void AplicarEntrenamientoLirico()
    {
        base.AplicarEntrenamientoLirico();
        Anotacion += 0.5;
    }
}
