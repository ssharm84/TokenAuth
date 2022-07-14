using TokenAuthantication.Models;
using AutoMapper;
using TokenAuthantication.DTOs;
using System.Text;

namespace TokenAuthantication.Helpers
{
    public class AutoMapperProfile: Profile
    {
       public AutoMapperProfile()
        {
            //CreateMap<TblBook, BookListDto>();
            CreateMap<LoginDTO, TblUser>();
            CreateMap<RegisterDTO, TblUser>()
           .ForMember(dest => dest.Password, opt => opt.MapFrom(src => Encoding.Unicode.GetBytes( src.Password)));

        }
    }

}