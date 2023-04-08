using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.RepositoryGeneric
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext; 
        private readonly Lazy<ICompanyRepository> _companyRepository; 
        private readonly Lazy<IEmployeeRepository> _employeeRepository; 
        public RepositoryManager(RepositoryContext repositoryContext) { 
            _repositoryContext = repositoryContext; 
            _companyRepository = new Lazy<ICompanyRepository>(() => 
                new CompanyRepository(repositoryContext));
            _employeeRepository = new Lazy<IEmployeeRepository>(() => 
                new EmployeeRepository(repositoryContext));
        } 
        public ICompanyRepository Company => _companyRepository.Value; 
        public IEmployeeRepository Employee => _employeeRepository.Value; 
        public void Save() => _repositoryContext.SaveChanges();
        
    }
}

// Save() método a utilizar después de todo el se terminan las modificaciones en un determinado objeto. 
// Esta es una buena práctica porque ahora podemos, por ejemplo, agregar dos empresas, modificar dos
// empleados y eliminar una empresa, todo en una sola acción, y luego simplemente llama a Save() método 
// una vez. Se aplicarán todos los cambios o si algo falla, todos los cambios serán revertidos:

// La parte interesante con elRepositoryManagerla implementación es que estamos aprovechando el poder del Lazy (perezoso)
// clase para asegurar la inicialización diferida de nuestros repositorios. Esto significa que nuestras instancias 
// de repositorio solo se van a crear cuando accedamos a ellos por primera vez, y no antes de eso.