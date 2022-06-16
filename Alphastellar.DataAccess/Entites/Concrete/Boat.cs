using Alphastellar.DataAccess.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.DataAccess.Entites.Concrete
{
    public class Boat : Vehicle {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BoatID { get; set; }
    }
}
