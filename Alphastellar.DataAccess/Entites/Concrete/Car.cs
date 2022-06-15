using Alphastellar.DataAccess.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.DataAccess.Entites.Concrete
{
    public class Car:Vehicle
    {
        public bool wheels { get; set; }
        public bool headlights { get; set; }
    }
}
