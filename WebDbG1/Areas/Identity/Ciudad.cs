using System.ComponentModel.DataAnnotations;

namespace WebDbG1.Areas.Identity
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(40)]
        public string? Nombre { get; set; }

        public int DptoId { get; set; }

        public Dpto? Dpto { get; set; }

        public ICollection<Persona> Personas { get; set; }
    }
}
