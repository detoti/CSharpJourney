using System;
using System.ComponentModel.DataAnnotations;

namespace CarsAPI.Models;

public class Carro
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "A marca é obrigatória.")]
    [MaxLength(20, ErrorMessage = "O tamanho do modelo não pode ser maior do que 20 caractes")]
    public string Marca { get; set; }

    [Required(ErrorMessage = "O Modelo é obrigatória.")]
    [MaxLength(20, ErrorMessage = "O tamanho do modelo não pode ser maior do que 20 caractes")]
    public string Modelo { get; set; }

    [Required]
    [Range(5, 2000, ErrorMessage = "A potência deve ser entre 5 e 2000hp")]
    public int Potencia { get; set; }

}

