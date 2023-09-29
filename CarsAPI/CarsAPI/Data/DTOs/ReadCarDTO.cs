using System;
using System.ComponentModel.DataAnnotations;
namespace CarsAPI.Data.DTOs;

public class ReadCarDTO
{
    public string Marca { get; set; }

    public string Modelo { get; set; }

    public int Potencia { get; set; }

    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}

