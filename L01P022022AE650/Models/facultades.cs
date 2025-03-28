using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace L01P022022AE650.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }
        public string facultad { get; set; }
    }
}
