﻿using AutoMapper;
using EntertainmentDatabase.REST.API.Domain.Entities;

namespace EntertainmentDatabase.REST.API.Presentation.DataTransferObjects.Mappings
{
    public class MovieDTOMapping : Profile
    {
        public MovieDTOMapping()
        {
            this.CreateMap<Movie, MovieDTO>()
                .ForMember(destination => destination.ConcurrencyToken,
                    option => option.MapFrom(source => source.RowVersion))
                .ReverseMap()
                .ForMember(source => source.RowVersion,
                    option => option.MapFrom(destination => destination.ConcurrencyToken));
        }
    }
}
