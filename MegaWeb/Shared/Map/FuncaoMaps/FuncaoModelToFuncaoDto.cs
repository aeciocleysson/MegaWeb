﻿using AutoMapper;
using MegaWeb.Shared.DTO.FuncaoDtos;
using MegaWeb.Shared.Models;

namespace MegaWeb.Shared.Map
{
    public class FuncaoModelToFuncaoDto : Profile
    {
        public FuncaoModelToFuncaoDto()
        {
            CreateMap<Funcao, FuncaoDto>().ReverseMap();
        }
    }
}