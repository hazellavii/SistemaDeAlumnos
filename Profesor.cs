// ETAPA 7 //
public class Profesor : Persona, IExportable
{
    public string Materia { get; set; }

    public Profesor(string nombre, int documento, string materia)
        : base(nombre, documento)
    {
        Materia = materia;
    }
    
    // ETAPA 8 //
    public override string Presentarse()
    {
        return $"Hola, soy {Nombre} y dicto {Materia}.";
    }
    
    // ETAPA 9 //
    public string ExportarLinea()
    {
        return $"PROFESOR;{Nombre};{Materia}";
    }
}