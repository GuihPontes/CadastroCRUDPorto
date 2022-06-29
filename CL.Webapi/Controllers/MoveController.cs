using CL.Core.Domain;
using CL.Core.DTO.Cliente;
using CL.Manager.InterfacesRepositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CL.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoveController : ControllerBase
    {
        private readonly IMoveManager move;

        public MoveController(IMoveManager move)
        {
            this.move = move;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Movimentacao), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            return Ok(await move.GetAsync());
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Movimentacao), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Movimentacao), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await move.GetAsync(id));
        }


    

       
        

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Movimentacao), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            await move.DeleteAsync(id);
            return NoContent();
        }

    }
}
