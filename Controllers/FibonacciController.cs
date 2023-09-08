using Microsoft.AspNetCore.Mvc;
using static WebApiFibonacci.Controllers.Fibonacci;

namespace WebApiFibonacci.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FibonacciController : ControllerBase
    {


        public FibonacciController()
        {

        }

        [HttpGet]
        [Route("getFibonacci")]
        public async Task<IActionResult> getFibonacci(int id)
        {
            Fibonacci _oper = new Fibonacci();
            //return Ok(await _fibonacci.getFibonacci(id));
            return Ok(await _oper.getFibonacci(id));

        }



    }

    public class Fibonacci //: IFibonacci
    {
        public async Task<string> getFibonacci(int id)
        {
            string resultado = "0";

            int a = 0, b = 1, c = 0;
            for (int i = 2; i < id+1; i++)
            {
                c = a + b;
                resultado = c.ToString();
                a = b;
                b = c;
            }
            return resultado;

        }
    }
    
}
