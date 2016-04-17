using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stomatolog.Domain.Models
{
    public class Patient
    {
        public Patient()
        {
            Visits = new List<Visit>();
            Pictures = new List<Picture>();
        }

        [Key]
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Pesel { get; set; }
        public string Nip { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        [ForeignKey("Diagram")]
        public int DiagramId { get; set; }

        public virtual Diagram Diagram { get; set; }
        
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
