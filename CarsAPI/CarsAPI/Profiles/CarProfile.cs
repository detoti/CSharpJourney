using System;
using AutoMapper;
using CarsAPI.Models;
using CarsAPI.Data.DTOs;

namespace CarsAPI.Profiles;

public class CarProfile : Profile
{
	public CarProfile()
	{
		CreateMap<CreateCarDTO, Carro>();
		CreateMap<UpdateCarDTO, Carro>();
        CreateMap<Carro, UpdateCarDTO>();
		CreateMap<Carro, ReadCarDTO>();
    }
}

