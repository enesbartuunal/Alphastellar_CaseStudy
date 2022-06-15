using Alphastellar.DataAccess.Entites.Concrete;
using Alphastellar.Model.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.Business.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>();
            CreateMap<Bus, BusDto>();
            CreateMap<Boat, BoatDto>();
        }
    }
}
