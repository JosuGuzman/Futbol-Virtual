namespace scr;

public class SesionLirica : Sesiones
{
    public override void AplicarA(Jugador jugador)
    {
        jugador.AplicarEntrenamientoLirico();
    }
}
