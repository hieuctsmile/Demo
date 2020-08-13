using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Shared;

namespace Model.Entites
{
    [Table("Status")]
    public class Status : DomainEntity<int>
    {
        public Status()
        {
        }

        public Status(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Status(string name)
        {
            Name = name;
        }

        [StringLength(255)]
        public string Name { set; get; }
    }
}