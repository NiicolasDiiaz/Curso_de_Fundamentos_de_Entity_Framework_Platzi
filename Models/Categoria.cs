namespace Curso_de_Fundamentos_de_Entity_Framework_Udemy.Models;

public class Categoria
{
    public Guid CategoriaId { get; set; }
    public string Nombre { get; set; }
    public string Descricpcion { get; set; }
    public virtual ICollection<Tarea> Tareas { get; set; }
}