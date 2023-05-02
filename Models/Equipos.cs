public static class Equipos{
    public static List<string> ListaEquipos {get; private set;} 
    public static List<string> ListaMedias {get;private set;}
    public static List<string> ListaPantalones {get;private set;}
    public static List<string> ListaRemeras {get;private set;}
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get;private set;}

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
    {
        if(!EquiposIndumentaria.ContainsKey(EquipoSeleccionado))
        {
        EquiposIndumentaria.Add(EquipoSeleccionado,item);
        return true;
        }else return false;
        
    }
}