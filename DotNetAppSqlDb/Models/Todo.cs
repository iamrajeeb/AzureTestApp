using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetAppSqlDb.Models
{
    public class Todo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Done { get; set; }
    }
}