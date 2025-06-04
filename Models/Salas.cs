using Newtonsoft.Json;
public class Salas{
    [JsonProperty]
    public bool llaveSala1;
    [JsonProperty]
    public bool luzSala2;
    [JsonProperty]
    public int numIngresado;
    [JsonProperty]
    public int numReal;
    [JsonProperty]
    public string palabraReal;
    [JsonProperty]
    public string palabraIngresada;
    public Salas(){
        llaveSala1=false;
        luzSala2=false;
        numReal=962;
        palabraReal="escape";
    }
    public string mismoNum(){
        string palabra= "Sala3";
        if(numIngresado==numReal)
        {
            palabra="Sala4";
        }
        return palabra;
    }
}