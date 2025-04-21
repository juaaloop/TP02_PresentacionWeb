class DatoFamiliar{
    public string Nombre {get; private set;}
    public string Apellido{get;private set;}
    public string Parentesco{get;private set;}
    public string Descripcion{get;private set;}

    public DatoFamiliar(string nombre,string apellido,string parentesco,string descripcion){
        Nombre = nombre;
        Apellido=apellido;
        Parentesco = parentesco;
        Descripcion = descripcion;
    }


}