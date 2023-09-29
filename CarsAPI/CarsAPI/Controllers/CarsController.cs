using CarsAPI.Models;
using CarsAPI.Data;
using CarsAPI.Data.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using AutoMapper;


[ApiController]
[Route("[controller]")]

public class CarsController : ControllerBase
{
    private CarContext _context;
    private IMapper _mapper;

    public CarsController(CarContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Adiciona um carro ao banco de dados
    /// </summary>
    /// <param name="carroDTO">Objeto com os campos necessários para criação de um carro</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AdicionarCarro([FromBody] CreateCarDTO carroDTO)
    {
        Carro carro = _mapper.Map<Carro>(carroDTO);
        _context.Carros.Add(carro);
        _context.SaveChanges();
        return CreatedAtAction(nameof(CarroPorId),
            new { id = carro.Id }, carro);
    }

    [HttpGet]

    public IEnumerable<ReadCarDTO> RecuperaCarros([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadCarDTO>>(_context.Carros.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]

    public IActionResult CarroPorId(int id)
    {
        var carro = _context.Carros.FirstOrDefault(
            carro => carro.Id == id);
        if (carro == null) return NotFound();
        var carroDTO = _mapper.Map<ReadCarDTO>(carro);
        return Ok(carroDTO);
    }

    [HttpPut("{id}")]

    public IActionResult AtualizaCarro(int id, [FromBody] UpdateCarDTO carDTO)
    {
        var carro = _context.Carros.FirstOrDefault(
            carro => carro.Id == id);
        if (carro == null) return NotFound();
        _mapper.Map(carDTO, carro);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]

    public IActionResult AtualizaCarroParcial(int id,
        JsonPatchDocument<UpdateCarDTO> patch)
    {
        var carro = _context.Carros.FirstOrDefault(
            carro => carro.Id == id);
        if (carro == null) return NotFound();

        var carroParaAtualizar = _mapper.Map<UpdateCarDTO>(carro);
        patch.ApplyTo(carroParaAtualizar, ModelState);

        if(!TryValidateModel(carroParaAtualizar))
        {
            return ValidationProblem(ModelState);
        } 
        _mapper.Map(carroParaAtualizar, carro);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]

    public IActionResult DeletaCarro(int id)
    {
        var carro = _context.Carros.FirstOrDefault(
                carro => carro.Id == id);
        if (carro == null) return NotFound();
        _context.Remove(carro);
        _context.SaveChanges();
        return NoContent();
    }
}

