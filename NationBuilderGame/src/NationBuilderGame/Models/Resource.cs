using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationBuilderGame.Models
{
    [Table("Resources")]
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        public int Iron { get; set; }
        public int Timber { get; set; }
        public int Oil { get; set; }
        public int NationId { get; set; }
        public virtual Nation Nation { get; set; }
        public virtual ApplicationUser User { get; set; }

        public Resource(int iron, int timber, int oil)
        {
            Iron = iron;
            Timber = timber;
            Oil = oil;
        }
        public Resource() { }
    }
}
