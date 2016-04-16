using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stomatolog.Domain.Models
{
    public class Visit
    {
        [Key]
        public int VisitId { get; set; }
        public string Description { get; set; }
        public DateTime? DateOfVisit { get; set; }
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }
    }
}
