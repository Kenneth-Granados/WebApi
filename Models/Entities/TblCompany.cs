using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class TblCompany
    {
        [Column("CompanyID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El nombre de la empresa es un campo obligatorio.")]
        [MaxLength(60, ErrorMessage = "La longitud máxima del nombre es de 60 caracteres.")]
        public string? Name { get; set; } 
        [Required(ErrorMessage = "La dirección de la empresa es un campo obligatorio.")] 
        [MaxLength(60, ErrorMessage = "La longitud máxima de la dirección es de 60 caracteres")] 
        public string? Address { get; set; } 
        public string? Country { get; set; }
        public ICollection<TblEmployee>? Employees { get; set; }
    }
}