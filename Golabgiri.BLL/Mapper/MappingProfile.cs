using AutoMapper;
using Golabgiri.Domain.Entities;
using Golabgiri.ViewModel.DTO.LoginDTO;
using Golabgiri.ViewModel.DTO.CustomerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Golabgiri.ViewModel.DTO.ProductDTO;

namespace Golabgiri.BLL.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<List<string>, LoginDTO>()
                 .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src[0]))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src[1]))
                .ReverseMap();

            CreateMap<Customer, CustomerDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.phoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.debit, opt => opt.MapFrom(src => src.Debit))
                .ForMember(dest => dest.credit, opt => opt.MapFrom(src => src.Credit))
                .ForMember(dest => dest.address, opt => opt.MapFrom(src => src.Address))
                .ReverseMap();

            CreateMap<Product,ProductDTO>()
                .ForMember(dest=>dest.ID,opt=>opt.MapFrom(src=>src.ProductId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.ProductUnit.UnitName))
                .ForMember(dest => dest.price, opt => opt.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.description, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();
        }
    }
}
