using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentDTO, Student>()
                .ForMember(d => d.City, s => s.MapFrom(s => s.CurrentCity));

            CreateMap<AddressDTO, Address>();
        }
    }
}
