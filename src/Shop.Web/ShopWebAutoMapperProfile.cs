using AutoMapper;
using Shop.Books;

namespace Shop.Web
{
    public class ShopWebAutoMapperProfile : Profile
    {
        public ShopWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<BookDto, CreateUpdateBookDto>();
        }
    }
}
