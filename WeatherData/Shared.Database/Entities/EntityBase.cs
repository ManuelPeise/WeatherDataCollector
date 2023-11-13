using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
