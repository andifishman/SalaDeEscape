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
    
    [JsonProperty]
    public string libertad;
        [JsonProperty]
    public string libertadIngresada;
    public Salas(){
        llaveSala1=false;
        luzSala2=false;
        numReal=932;
        palabraReal="escape";
        palabraIngresada="";
        libertad = "libertad";
        libertadIngresada = "";
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
        palabraIngresada=palabraNueva;
    }
     public string mismaPalabra()
     {
        string palabra = "Sala4";
        if(palabraIngresada==palabraReal)
        {
            palabra = "Sala5";
        }
        return palabra;
    }
    public void palabra2(string palabraNueva){
        libertadIngresada=palabraNueva;
    }
    public string mismaPalabra2()
     {
        string palabra = "Sala5parte2";
        if(libertadIngresada==libertad)
        {
            palabra = "Ganar";
        }
        return palabra;
    }
}   