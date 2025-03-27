using scr;

namespace FutbolVirtual.Test;

public class TestFutbolTest
{
    [Fact]
    public void Atacante_AplicarEntrenamientoLirico_IncreasesAnotacion()
    {
        // Arrange
        var atacante = new Atacante { Anotacion = 5 };

        // Act
        atacante.AplicarEntrenamientoLirico();

        // Assert
        Assert.Equal(5.5, atacante.Anotacion);
    }

    [Fact]
    public void Defensor_AplicarEntrenamientoFisico_IncreasesQuite()
    {
        // Arrange
        var defensor = new Defensor { Quite = 3 };

        // Act
        defensor.AplicarEntrenamientoFisico();

        // Assert
        Assert.Equal(3.5, defensor.Quite);
    }

    [Fact]
    public void Equipo_Entrenar_AppliesSessionsToAllPlayers()
    {
        // Arrange
        var equipo = new Equipo
        {
            Jugadores = new List<Jugador>
            {
                new Atacante { Anotacion = 5 },
                new Defensor { Quite = 3 }
            },
            Sesiones = new List<Sesiones>
            {
                new SesionFisica(),
                new SesionLirica()
            }
        };

        // Act
        equipo.Entrenar();

        // Assert
        Assert.Equal(6.5, ((Atacante)equipo.Jugadores[0]).Anotacion);
        Assert.Equal(4.5, ((Defensor)equipo.Jugadores[1]).Quite);
    }

    [Fact]
    public void Equipo_GetPotencia_ReturnsSumOfTopTwoPlayersPotencia()
    {
        // Arrange
        var equipo = new Equipo
        {
            Jugadores = new List<Jugador>
            {
                new Atacante { Potencia = 10 },
                new Defensor { Potencia = 8 },
                new Atacante { Potencia = 6 }
            }
        };

        // Act
        var potencia = equipo.GetPotencia();

        // Assert
        Assert.Equal(18, potencia);
    }

    [Fact]
    public void Equipo_GetPrecision_ReturnsCalculatedPrecision()
    {
        // Arrange
        var equipo = new Equipo
        {
            Jugadores = new List<Jugador>
            {
                new Atacante { Anotacion = 5, HabilidadPases = 2 },
                new Defensor { Quite = 3, HabilidadPases = 1 }
            }
        };

        // Act
        var precision = equipo.GetPrecision();

        // Assert
        Assert.Equal(24, precision);
    }

    [Fact]
    public void Equipo_GetVision_ReturnsCalculatedVision()
    {
        // Arrange
        var equipo = new Equipo
        {
            Jugadores = new List<Jugador>
            {
                new Atacante { VisionJuego = 3, HabilidadPases = 2 },
                new Defensor { VisionJuego = 4, VisionCompaneros = 1 }
            }
        };

        // Act
        var vision = equipo.GetVision();

        // Assert
        Assert.Equal(10, vision);
    }
}
