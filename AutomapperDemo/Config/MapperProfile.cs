using AutoMapper;
using AutomapperDemo.Models;

namespace AutomapperDemo.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BookDTO, Book>().ForMember(
                des=>des.Id,
                opt=>opt.MapFrom(src=>src.BookId)).ReverseMap();
        }
    }
}
