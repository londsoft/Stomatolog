using Stomatolog.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stomatolog.Domain.Mappings
{
    public class VisitMap : EntityTypeConfiguration<Visit>
    {
        public VisitMap()
        {
            this.ToTable("Wizyty");
        }
    }
}
