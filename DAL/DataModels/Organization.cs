using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DataModels
{
    [Table("Organizations")]
    public class Organization: PersistentObject
    {
        public string Name { get; set; }
    }
}