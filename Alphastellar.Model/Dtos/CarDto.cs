
using Alphastellar.Model.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.Model.Dtos
{
    public class CarDto: MainDto
    { 
        public int CarID { get; set; }
        public bool wheels { get; set; }
        public bool headlights { get; set; }
    }
}
