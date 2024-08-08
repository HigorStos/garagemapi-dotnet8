using System.ComponentModel.DataAnnotations;

namespace GaragemApi;

public class Veiculo
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Placa { get; set; }
    [Required]
    public string Modelo { get; set; }
    [Required]
    public string Fabricante { get; set; }
    [Required]
    public int Ano { get; set; }
    [Required]
    public int Kilometragem { get; set; }
}
