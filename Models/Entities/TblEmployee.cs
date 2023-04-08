using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class TblEmployee
    {
        [Column("EmployeeID")] 
        public Guid Id { get; set; } 

        [Required(ErrorMessage = "El nombre del empleado es un campo obligatorio.")] 
        [MaxLength(30, ErrorMessage = "La longitud máxima del nombre es de 30 caracteres.")] 
        public string? Name { get; set; } 

        [Required(ErrorMessage = "La edad es un campo obligatorio.")] 
        public int Age { get; set; } 
        
        [Required(ErrorMessage = "El puesto es un campo obligatorio.")] 
        [MaxLength(20, ErrorMessage = "La longitud máxima de la posición es de 20 caracteres.")] 
        public string? Position { get; set; } 

        [ForeignKey(nameof(Company))] 
        public Guid CompanyID { get; set; } 
        public TblCompany? Company { get; set; }
    }
}