using AutoMapper;
using Contracts.DTOs.Stories;
using Domain;
using Domain.Entities;
using Services.DTOs.Episodes;
using Services.DTOs.StoriyCategories;

namespace Services;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region Story
        CreateMap<Story, StoryResponseDTO>();
        CreateMap<Episode, EpisodeResponseDTO>()
            .ForMember(dest => dest.Link, opt => opt.MapFrom(src => src.Audio.Link))
            .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Audio.Duration));
        
        CreateMap<StoryCreateRequest, Story>()
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Desription))
            .ForMember(dest => dest.Episodes, opt => opt.MapFrom(src => src.Episodes));

        CreateMap<EpisodeCreateRequest, Episode>()
            .ForMember(dest => dest.OrderNumber, opt => opt.MapFrom(src => src.OrderNumber))
            .ForMember(dest => dest.Audio, opt => opt.MapFrom(src => new Audio { Link = src.File, Duration = src.Duration}));
        #endregion

        #region StoryCategory

        CreateMap<StoryCategory, StoryCategoryResponseDTO>();

        #endregion
    }
}