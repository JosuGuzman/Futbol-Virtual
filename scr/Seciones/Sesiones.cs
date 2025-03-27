namespace scr;

public abstract class Sesiones
{
    public string Nombre { get; set; } = "";

    public abstract void AplicarA(Jugador jugador);
}
