using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync() //método sincrono, mais lento, para acesso a BD, HD e etc: public List<Department> FindAll().
        {
            // modificado. return _context.Department.OrderBy(x => x.Name).ToList();
            // o ToList é um método síncrono. Para assíncrono, ToListAsync e acréscimo do await para definir assíncrono conforme abaixo.
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
