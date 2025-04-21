static class Grupo
{
    static public Dictionary<int, Integrante> Integrantes { get;  set; }

    static Grupo(){
       Integrantes = new Dictionary<int, Integrante>();    
       }
    static public void InicializarGrupo()
    {
        
        int dni =49193480;
        DatoPersonal dPersonal = new DatoPersonal("Iara", "Szwarstein", new DateTime(2009,01,24), "IaraPic.jpg");
        List<DatoFamiliar> datosFamiliares = new List<DatoFamiliar> { new DatoFamiliar("Mariana", "Rosen", "Madre", "N/a"), new DatoFamiliar("Pablo", "Szw", "Padre", "N/a") };
        DatoInteres DatosIntereses = new DatoInteres("Escuchar Musica, Gaming, Crochet, Caminar", "The Mentalist, Dragones: Carrera al borde", "Milu, Mia, Tati, Juana +(20)", "Fisica, programacion, matematica");
        Integrantes.Add(dni, new Integrante(dni, dPersonal, datosFamiliares, DatosIntereses));

        dni =49002406;
        dPersonal = new DatoPersonal("Juana", "López", new DateTime(2008,10,17), "JuanaPic.jpg");
        datosFamiliares = new List<DatoFamiliar> { new DatoFamiliar("J", "L.", "padre", "descripcion"), new DatoFamiliar("Amado", "L.V.", "hermano", "mi hermano") };
        DatosIntereses = new DatoInteres("Tocar el bajo", "No hay información", "Historia y Física", "TI");
        Integrantes.Add(dni, new Integrante(dni, dPersonal, datosFamiliares, DatosIntereses));

        dni =48860740;
        dPersonal = new DatoPersonal("Tatiana ", "Brojan ", new DateTime(2008,08,16), "TatiPic.jpg");
        datosFamiliares = new List<DatoFamiliar> { new DatoFamiliar("G", "M", "madre", "descripción"), new DatoFamiliar("S", "B", "padre", "descripción") };
        DatosIntereses = new DatoInteres("Leer", "Percy Jackson", "Iara!!", "Lengua");
        Integrantes.Add(dni, new Integrante(dni, dPersonal, datosFamiliares, DatosIntereses));

    }

    static public Dictionary<int, Integrante> devolverGrupo(){
        return Integrantes;
    }
}