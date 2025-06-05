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
    public void llaveTrue()
    {
        llaveSala1=true;
    }
    public void luzTrue()
    {
        luzSala2=true;
    }
    public void num(int numeroNuevo){
        numIngresado=numeroNuevo;
    }
     public void palabra(string palabraNueva){
        numIngresado=palabraNueva;
    }
     public string mismaPalabra(){
        string palabra= "Sala4";
        if(palabraIngresada==palabraReal)
        {
            palabra="Ganar";
        }
        return palabra;
    }
}