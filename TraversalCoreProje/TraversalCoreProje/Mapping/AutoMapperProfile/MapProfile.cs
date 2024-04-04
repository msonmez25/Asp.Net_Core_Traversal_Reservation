using AutoMapper;
using DTOLayer.DTOs.Announcement;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ContactDTOS;
using EntityLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AddAnnouncementDto, Announcement>();
            CreateMap<Announcement, AddAnnouncementDto>();

            CreateMap<ViewAnnouncementDto, Announcement>();
            CreateMap<Announcement, ViewAnnouncementDto>();


            CreateMap<UpdateAnnouncementDto, Announcement>();
            CreateMap<Announcement, UpdateAnnouncementDto>();

            CreateMap<AppUserRegisterDto, AppUser>();
            CreateMap<AppUser, AppUserRegisterDto>();

            CreateMap<AppUserLoginDto, AppUser>();
            CreateMap<AppUser, AppUserLoginDto>();

            CreateMap<SendMessageDto, ContactUs>().ReverseMap();


        }
    }

}
