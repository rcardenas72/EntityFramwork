using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;
using Microsoft.Net.Http.Headers;

namespace ef.models;
public class Tarea
{
    [Key]
    [Required]
    public Guid TareaId {get;set;}
    [ForeignKey("CategoriaID")]
    public Guid CategoriaId {get;set;}

    [Required]
    [StringLength(200)]
    public string Titulo {get;set;}
    
    [StringLength(200)]
    public string? Descripcion {get;set;}
    public Prioridad PrioridadTarea {get;set;}
    public DateTime FechaCreacion {get;set;}
    public virtual Categoria? Categoria {get;set;}

    [NotMapped]
    public string? Resumen {get;set;}
}

public enum Prioridad 
{
    Baja,
    Media,
    Alta
}