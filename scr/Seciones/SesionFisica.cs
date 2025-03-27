namespace scr;

public class SesionFisica : Sesiones
{
    public override void AplicarA(Jugador jugador)
    {
        jugador.AplicarEntrenamientoFisico();
    }
}
