using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Location: BaseEntity
    {
        public int Grade { get; set; }
        public string Description { get; set; }
        public string Reviews { get; set; }
        public string Category { get; set; }
    }
}
