using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationBuilderGame.Models
{
    [Table("Goverments")]
    public class Government
    {
        [Key]
        public int GovernmentId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int ResourceModifier { get; set; }
        public int StabilityModifier { get; set; }
        public int CapitalModifier { get; set; }
        public int PopulationModifier { get; set; }
        public int NationId { get; set; }
        public virtual Nation Nation { get; set; }
        public virtual ApplicationUser User { get; set; }

        public Government( string type, string description, int resourceModifier, int stabilityModifier, int capitalModifier, int populationModifier)
        {
            Type = type;
            Description = description;
            ResourceModifier = resourceModifier;
            StabilityModifier = stabilityModifier;
            CapitalModifier = capitalModifier;
            PopulationModifier = populationModifier;
        }

        public Government() { }
    }
}
