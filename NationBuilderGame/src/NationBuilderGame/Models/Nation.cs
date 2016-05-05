using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationBuilderGame.Models
{
    [Table("Nations")]
    public class Nation
    {
        [Key]
        public int NationId { get; set; }
        public string Name { get; set; }
        public int Capital { get; set; }
        public int Population { get; set; }
        public float Stability { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual Government Goverment { get; set; }
        public virtual Economy Economy { get; set; }
        public virtual Geography Geography { get; set; }
        public virtual ApplicationUser User { get; set; }

        public override bool Equals(System.Object otherNation)
        {
            if (!(otherNation is Nation))
            {
                return false;
            }
            else
            {
                Nation newNation = (Nation)otherNation;
                return this.NationId.Equals(newNation.NationId);
            }
        }

        public override int GetHashCode()
        {
            return this.NationId.GetHashCode();
        }
    }
}
