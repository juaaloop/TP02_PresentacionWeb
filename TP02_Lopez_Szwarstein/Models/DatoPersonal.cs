class DatoPersonal{
    public string Nombre {get; private set;}
    public string Apellido{get;private set;}
    public DateTime FechaNacimiento{get;private set;}
    public string Foto{get;private set;}

    public DatoPersonal(string nombre,string apellido,DateTime fechaNacimiento,string foto){
        Nombre = nombre;
        Apellido=apellido;
        FechaNacimiento = fechaNacimiento;
        Foto = foto;
    }

    public int ObtenerEdad(){
        return DateTime.Today.Year - FechaNacimiento.Year;
    }
}