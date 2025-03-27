namespace scr;

public class Defensor : Jugador
{
    public double Quite { get; set; }

    public override double GetPrecision() => Quite;

    public override double GetVisionGeneral() => VisionJuego + VisionCompaneros;

    public new void AplicarEntrenamientoFisico()
    {
        base.AplicarEntrenamientoFisico();
        Quite += 0.5;
    }
    
    public new void AplicarEntrenamientoLirico()
    {
        base.AplicarEntrenamientoLirico();
    }
}