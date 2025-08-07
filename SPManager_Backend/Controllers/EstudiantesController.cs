using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPManager_Backend.Data;
using SPManager_Backend.Models;

namespace SPManager_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        //private readonly AppDbContext _context; //Se genero automaticamente al crear el controlador
        public AppDbContext _context;

        public EstudiantesController(AppDbContext context)
        {
            _context = context;
        }

        #region Obtener todos
        // GET: api/Estudiantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiantes>>> GetEstudiantes()
        {
            return await _context.Estudiantes.ToListAsync();
        }
        #endregion
    }
}
