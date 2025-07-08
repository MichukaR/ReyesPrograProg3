using System.ComponentModel.DataAnnotations;

namespace ReyesMMProgIII.Models;

public class Producto
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioEstimado { get; set; }
}