using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ef.models;

public class Categoria
{
   // [Key]
    public Guid CategoriaId{get;set;}

  //  [Required]
   // [StringLength(150)]

    public  string Nombre {get;set;}

  //  [StringLength(250)]
    public string? Descripcion {get;set;}   

    public int Peso {get;set;}   

    [JsonIgnore]
     public virtual ICollection<Tarea>? Tareas {get;set;}

}