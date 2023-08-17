using AutoMapper;
using DTO.DTOs.AnnouncementDTOs;
using Entity.Concrete;

namespace Web.Mapping.AutoMapperProfile;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<AnnouncementAddDTO, Announcement>();
        CreateMap<Announcement, AnnouncementAddDTO>();
        CreateMap<AnnouncementListDto, Announcement>();
        CreateMap<Announcement, AnnouncementListDto>();
        CreateMap<AnnouncementUpdateDto, Announcement>();
        CreateMap<Announcement, AnnouncementUpdateDto>();
    }
    
}