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
        public string Name { get; set; }
        public int Capital { get; set; }
        public int Iron { get; set; }
        public int Timber { get; set; }
        public int Oil { get; set; }
        public int Population { get; set; }
        public float stability { get; set; }
    }

    public override bool Equals(System.Object otherItem)
    {
        if (!(otherItem is Item))
        {
            return false;
        }
        else
        {
            Item newItem = (Item)otherItem;
            return this.ItemId.Equals(newItem.ItemId);
        }
    }

    public override int GetHashCode()
    {
        return this.ItemId.GetHashCode();
    }
}
