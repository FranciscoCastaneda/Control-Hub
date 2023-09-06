using ControlHub.WebApi.BusinessLogic.Interfaces;
using ControlHub.WebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ControlHub.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : Controller
    {
        private readonly IFibonacciBusinessLogic logic;

        public FibonacciController(IFibonacciBusinessLogic logic)
        {
            this.logic = logic;
        }

        /// <summary>
        /// Método para calcular el numero Fibonacci a partir de un numero proporcionado
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(int index)
        {
            try
            {
                if (index == default)
                    return StatusCode(StatusCodes.Status400BadRequest, "Parametro de entrada 'index' es necesario para procesar la solicitud.");

                var output = await logic.GetFibonacciByIndex(index);

                return Ok(new FibonacciResponse
                {
                    Input = index,
                    Output = output,
                    Result = $"El número: {index} corresponde al numero Fibonacci: {output}"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }
}
