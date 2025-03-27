namespace scr;

public class Equipo
{
    public List<Jugador> Jugadores { get; set; } = new List<Jugador>();
    public List<Sesiones> Sesiones { get; set; } = new List<Sesiones>();

    public void Entrenar()
    {
        foreach (var jugador in Jugadores)
        {
            foreach (var sesion in Sesiones)
            {
                sesion.AplicarA(jugador);
            }
        }
    }

    public double GetPotencia()
    {
        return Jugadores.OrderByDescending(j => j.Potencia).Take(2).Sum(j => j.Potencia);
    }

    public double GetPrecision()
    {
        return Jugadores.Sum(j => 3 * j.GetPrecision() + j.HabilidadPases);
    }

    public double GetVision()
    {
        return Jugadores.Sum(j => j.GetVisionGeneral());
    }
}