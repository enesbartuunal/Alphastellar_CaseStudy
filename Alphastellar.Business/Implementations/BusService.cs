﻿using Alphastellar.Business.Services;
using Alphastellar.DataAccess.Context;
using Alphastellar.DataAccess.Entites.Concrete;
using Alphastellar.Model.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.Business.Implementations
{
    public class BusService : ServiceAbstractBase<Bus, BusDto>
    {
        public BusService(ApplicationDbContext db, IMapper mapper) : base(db, mapper)
        {
        }
    }
}
