using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionTareas.Models;

public class Tarea {
    [Key]

    public int TareaID { get; set; }
    public DateTime TareaFecha { get; set; }
    public string? TareaDescripcion { get; set; }
    public Prioridad TareaPrioridad { get; set; }
    public bool Realizado { get; set; }
    public string? UsuarioID { get; set; }

    [NotMapped]
    public string TareaPrioridadString { get {return TareaPrioridad.ToString();} } 
}


public enum Prioridad{
    Alta = 1,
    Media,
    Baja
}