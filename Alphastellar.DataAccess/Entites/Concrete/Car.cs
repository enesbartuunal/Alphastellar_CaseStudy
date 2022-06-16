using Alphastellar.DataAccess.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.DataAccess.Entites.Concrete
{
    public class Car:Vehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarID { get; set; }
        public bool wheels { get; set; }
        public bool headlights { get; set; }
    }
}
