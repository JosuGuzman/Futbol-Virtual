namespace scr;

public class SesionTactica : Sesiones
{
    public override void AplicarA(Jugador jugador)
    {
        jugador.AplicarEntrenamientoTactico();
    }
}
