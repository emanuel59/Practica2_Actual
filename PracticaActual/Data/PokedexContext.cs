using Microsoft.EntityFrameworkCore;
using PracticaActual.Models;

namespace PracticaActual.Data
{
    public class PokedexContext : DbContext
    {
        public DbSet<Pokemon> Pokemones { get; set; }

        public PokedexContext(DbContextOptions dco): base(dco){

        }
    }
}