using Curso_de_Fundamentos_de_Entity_Framework_Udemy.Models;
using Microsoft.EntityFrameworkCore;

namespace Curso_de_Fundamentos_de_Entity_Framework_Udemy;

public class TareasContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }


    public TareasContext(DbContextOptions<TareasContext> options) : base (options) { }
}