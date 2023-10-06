namespace webApi;

public class ManejoTareas{
    private AccesoATarea accesoATarea;
    private List<Tarea> listadoTareas;

    public ManejoTareas(){
        listadoTareas = new List<Tarea>();
        accesoATarea = new AccesoATarea();
    }
    public Tarea CrearTarea(Tarea tarea){
        listadoTareas = accesoATarea.Obtener();
        listadoTareas.Add(tarea);
        tarea.Id = ++Tarea.Autonumerico;
        accesoATarea.Guardar(listadoTareas);
        return tarea;
    }

    public Tarea GetTarea(int id){
        listadoTareas = accesoATarea.Obtener();
        var tarea = listadoTareas.FirstOrDefault(t => t.Id == id);
        return tarea;
    }

    public Tarea ActualizarTarea(int id, Estados estado){
        listadoTareas = accesoATarea.Obtener();
        var tarea = listadoTareas.FirstOrDefault(t => t.Id == id);
        if(tarea != null){
            tarea.Estado = estado;
            accesoATarea.Guardar(listadoTareas);
        }
        return tarea;
    }

    public bool EliminarTarea(int id){
        listadoTareas = accesoATarea.Obtener();
        var tarea = listadoTareas.FirstOrDefault(t => t.Id == id);
        if(tarea != null){
            bool exito = listadoTareas.Remove(tarea);
            if(exito){
                accesoATarea.Guardar(listadoTareas);
                return true;
            }
        }
        return false;
    }

    public List<Tarea> GetTareas(){
        listadoTareas = accesoATarea.Obtener();
        return listadoTareas;
    }

    public List<Tarea> GetTareasCompletadas(){
        List<Tarea> tareasCompletadas = new List<Tarea>();
        listadoTareas = accesoATarea.Obtener();
        foreach (var tarea in listadoTareas)
        {
            if(tarea.Estado == Estados.Completada){
                tareasCompletadas.Add(tarea);
            }
        }
        return tareasCompletadas;
    }
}