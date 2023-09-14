using Veterinary.API.Data;
using Owner.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Veterinary.API.Controllers
{

    [ApiController]
    [Route("api/owners")]
    public class OwnersController : ControllerBase
    {

        private readonly DataContext _context;


        public OwnersController(DataContext context)
        {
            _context = context;
        }

        //GET CON LISTA
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //200 TODO OK
            //204
            //400
            //401
            //500 ERROR DE CODIGO
            //AWAIT=ESPERAR
            //DEBE RESPONDER AL CONTEXT DE CIENTIFICOS
            //CUANDO EL METODO ES GET CON PARAMETROS SOLO MUESTRA ALGUNOS DATOS
            //CUANDO EL METODO ES GET SIN PARAMETROS MUESTRA TODOS LOS DATOS (SELECT * FROM CIENTIFICOS)
            return Ok(await _context.Owners.ToListAsync());


        }

        // METODO GET CON PARAMETROS
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            //200 TODO OK
            //204
            //400
            //401
            //500 ERROR DE CODIGO
            //AWAIT=ESPERAR
            //DEBE RESPONDER AL CONTEXT DE CIENTIFICOS
            //CUANDO EL METODO ES GET CON PARAMETROS SOLO MUESTRA ALGUNOS DATOS
            //CUANDO EL METODO ES GET SIN PARAMETROS MUESTRA TODOS LOS DATOS (SELECT * FROM CIENTIFICOS)
            await _context.Owners.FirstOrDefaultAsync(x => x.Id == id);

            return Ok();


        }

        //EL POST PUEDE MODIFICAR LA TABLA
        //INSERTAR UN REGISTRO
        [HttpPost]
        public async Task<ActionResult> Post(Owner owner)
        {


            _context.Add(owner);
            await _context.SaveChangesAsync();
            return Ok(owner);

        }
    }