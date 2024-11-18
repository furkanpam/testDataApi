using ConnectionProvider.Abstraction.Contracts.Dtos.Integrations;
using ConnectionProvider.Core.Mapper;
using ConnectionProvider.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Application.Mapper
{
    public class MapperProfile : MapperProfileBase
    {
        public MapperProfile()
        {
            CreateMap<ExchangeRate, ExchangeRateDto>().ReverseMap();
            CreateMap<ConversionRate, ConversionRatesDto>().ReverseMap();
        }
    }
}
