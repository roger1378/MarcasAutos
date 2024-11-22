using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Autos.Repository.Models;

public class MarcasAuto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid Id { get; set; }

    [MaxLength(64)]
    public string Marca { get; set; }

    [MaxLength(64)]
    public string Modelo { get; set; }

    public int Anno { get; set; }

    [MaxLength(64)]
    public string Color { get; set; }

    public bool IsActive { get; set; }

    public string Serial { get; set; }
}
