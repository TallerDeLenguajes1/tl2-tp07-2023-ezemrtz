using System.Text.Json;
using System.Text.Json.Serialization;
namespace webApi;
public class AccesoATarea{
    private string path = "tareas.json";
    public List<Tarea> Obtener(){
        List<Tarea> tareas = new List<Tarea>();
        if(File.Exists(path)){
            string json = File.ReadAllText(path);
            tareas = JsonSerializer.Deserialize<List<Tarea>>(json);
        }
        return tareas;
    }
    public void Guardar(List<Tarea> tareas){
        if(File.Exists(path)){
            string txt = JsonSerializer.Serialize(tareas);
            File.WriteAllText(path, txt);
        }
    }
}