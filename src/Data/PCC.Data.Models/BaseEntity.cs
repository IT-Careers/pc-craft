using System.ComponentModel.DataAnnotations;

namespace PCC.Data.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public string Id { get; set; }
    }
}
