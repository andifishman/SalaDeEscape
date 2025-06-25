using System;
using System.Diagnostics;

public class CronometroInterno
{
    public Stopwatch _stopwatch;
    public CronometroInterno()
    {
        _stopwatch = new Stopwatch();
    }

    public void Iniciar()
    {
        _stopwatch.Restart();
    }

    public void DetenerYGuardar()
    {
        _stopwatch.Stop();
        // Guarda el tiempo transcurrido donde lo necesites:
    }
    public TimeSpan ObtenerTiempo()
    {
        return _stopwatch.Elapsed;
    }
}