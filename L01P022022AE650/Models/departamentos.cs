using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace L01P022022AE650.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }
        public string departamento { get; set; }
    }
}
