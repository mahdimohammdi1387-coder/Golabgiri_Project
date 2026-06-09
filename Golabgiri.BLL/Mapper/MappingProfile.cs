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


        }
    }
}
