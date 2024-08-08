using System.ComponentModel.DataAnnotations;

namespace GaragemApi.Data.Dtos
{
    public class CreateVeiculoDto
    {
        [Required(ErrorMessage = "A placa do veículo é obrigatória")]
        [StringLength(8, ErrorMessage = "O tamanho da placa não pode exceder 8 caracteres")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "O modelo do veículo é obrigatório")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "O fabricante do veículo é obrigatório")]
        public string Fabricante { get; set; }
        [Required(ErrorMessage = "O ano do veículo é obrigatório")]
        public int Ano { get; set; }
        [Required(ErrorMessage = "A kilometragem do veículo é obrigatório")]
        public int Kilometragem { get; set; }
    }
}
