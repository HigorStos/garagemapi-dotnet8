namespace GaragemApi.Data.Dtos;

public class ReadVeiculoDto
{
    public int Id { get; set; }
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Fabricante { get; set; }
    public int Ano { get; set; }
    public int Kilometragem { get; set; }
}
