public static class Equipos{
    public static List<string> ListaEquipos {get; private set;} = new List<string> {"Boca","San Lorenzo","Temperley","Newells","Colo Colo","Man City","Man Utd","Independiente","AllBoys","Almagro"};
    public static List<string> ListaMedias {get;private set;} = new List<string> {"azules_medias.png","blancas_medias.png","bobesponja_medias.png","celestes_medias.jpg","messi_medias.png","negras_medias.png","psg_medias.png","rojas_medias.jpg","strangerthings_medias.png","velez_medias.png"};
    public static List<string> ListaPantalones {get;private set;} = new List<string> {"amarillos_pantalon.png","azules_pantalon.jpg","blancos_pantalon.png","boca_pantalon.png","celestes_pantalon.png","lakers_pantalon.png","lt_pantalon.png","negro_pantalon.png","salmon_pantalon.png","sanmartin_pantalon.png"};
    public static List<string> ListaRemeras {get;private set;} = new List<string> {"azul_remera.png","blanca_remera.png","boca_remera.png","celeste_remera.png","dorada_remera.png","falsochicago_remera.png","roja_remera.png","sanlorenzo_remera.png","temperley_remera.png","tirosuizo_remera.png"};
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get;private set;} = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
    {
        if(!EquiposIndumentaria.ContainsKey(EquipoSeleccionado))
        {
        EquiposIndumentaria.Add(EquipoSeleccionado,item);
        return true;
        }else return false;
        
    }
}