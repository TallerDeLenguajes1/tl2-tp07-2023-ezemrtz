namespace webApi;

public enum Estados{
    Pendiente,
    EnProgreso,
    Completada
}

public class Tarea{
    private static int autonumerico = 0;
    private int id;
    private string titulo;
    private string descripcion;
    private Estados estado;

    public static int Autonumerico { get => autonumerico; set => autonumerico = value; }
    public int Id { get => id; set => id = value; }
    public string Titulo { get => titulo; set => titulo = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public Estados Estado { get => estado; set => estado = value; }
}