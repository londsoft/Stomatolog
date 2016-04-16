using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stomatolog.Domain.Models
{
    public class Diagram
    {
        [Key]
        public int DiagramId { get; set; }
        public int PozX { get; set; }
        public int PozY { get; set; }
        public int Color { get; set; }
        public int Type { get; set; }
        public int State { get; set; }
    }
}
