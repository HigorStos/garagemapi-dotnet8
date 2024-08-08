using AutoMapper;
using GaragemApi.Data;
using GaragemApi.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace GaragemApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class VeiculoController : ControllerBase
{
    private GaragemContext _context;
    private IMapper _mapper;

    public VeiculoController(GaragemContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaVeiculo([FromBody] CreateVeiculoDto dto)
    {
        Veiculo veiculo = _mapper.Map<Veiculo>(dto);
        _context.Veiculos.Add(veiculo);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaVeiculoPorId), new { id = veiculo.Id }, veiculo);
    }

    [HttpGet]
    public IEnumerable<ReadVeiculoDto> RecuperaVeiculo(
        [FromQuery] int pagina = 0,
        [FromQuery] int tamanhoPagina = 5
    )
    {
        return _mapper.Map<List<ReadVeiculoDto>>
            (_context.Veiculos.Skip(pagina * tamanhoPagina).Take(tamanhoPagina).ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaVeiculoPorId(int id)
    {
        var veiculo = _context.Veiculos.FirstOrDefault(veiculo => veiculo.Id == id);
        if (veiculo == null) return NotFound();
        var veiculoDto = _mapper.Map<ReadVeiculoDto>(veiculo);
        return Ok(veiculoDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaVeiculos(int id, [FromBody] UpdateVeiculoDto dto)
    {
        var veiculo = _context.Veiculos.FirstOrDefault(veiculo => veiculo.Id == id);
        if (veiculo == null) return NotFound();
        _mapper.Map(dto, veiculo);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaVeiculo(int id)
    {
        var veiculo = _context.Veiculos.FirstOrDefault(veiculo => veiculo.Id == id);
        if (veiculo == null) return NotFound();
        _context.Veiculos.Remove(veiculo);
        _context.SaveChanges();
        return NoContent();
    }
}
