class Integrante{
    public int Dni {get; private set;}
    public DatoPersonal DatosPersonales {get; private set;}
    public List<DatoFamiliar> DatosFamiliares{get; private set;}
    public DatoInteres DatosIntereses {get; private set;}

    public Integrante(int dni, DatoPersonal datosPersonales, List<DatoFamiliar> datosFamiliares, DatoInteres datosIntereses){
        Dni = dni;
        DatosPersonales = datosPersonales;
        DatosFamiliares = datosFamiliares;
        DatosIntereses = datosIntereses;
    }
}