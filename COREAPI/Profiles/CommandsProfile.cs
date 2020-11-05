using AutoMapper;
using COREAPI.Dtos;
using COREAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COREAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //mapping DTO for GET 
            CreateMap<Command, CommandReadDto>();

            //mapping DTO for POST
            CreateMap<CommandCreateDto, Command>();

            //mapping DTO for PUT
            CreateMap<CommandUpdateDto, Command>();

            //mapping DTO for PATCH
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
