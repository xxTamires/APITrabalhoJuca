using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
