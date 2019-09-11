using System.Collections.Generic;

namespace API.Entities
{
    public class Location: BaseEntity
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Description { get; set; }
        public string Reviews { get; set; }
        public Category categoria { get; set; }
    }
}
