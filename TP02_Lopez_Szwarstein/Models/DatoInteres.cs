class DatoInteres
{
    public string Hobbies { get; private set; }
    public string SeriesFavoritas { get; private set; }
    public string Amigos { get; private set; }
    public string GustosEscolares { get; private set; }

    public DatoInteres(string hobbies, string seriesfavoritas, string amigos, string gustosescolares){
        Hobbies= hobbies;
        SeriesFavoritas= seriesfavoritas;
        Amigos= amigos;
        GustosEscolares= gustosescolares;
        
    }
}