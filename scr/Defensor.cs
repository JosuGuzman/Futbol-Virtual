namespace scr;

public class Defensor : Jugador
{
    public double Quite { get; set; }

    public override double GetPrecision() => Quite;
    public override double GetVisionGeneral() => VisionJuego + VisionCompaneros;
}