using Microsoft.AspNetCore.Mvc;
using NetCoreYouTube.Models;

namespace CursoMicroTiburones.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        //[Route("listar")]
        public dynamic listarCliente()
        {
            //Todo el codigo

            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                   id = 1,
                   nombre = "martin",
                   apellido = "pena",
                   cuil = "20232359464",
                   tipoDocumento = "dni",
                   nroDocumento = 23235946,
                   esEmpleadoBNA = true,
                   paisOrigen = "Argentina"

                },
                new Cliente
                {
                    
                   id = 2,
                   nombre = "martin",
                   apellido = "pena",
                   cuil = "20232359464",
                   tipoDocumento = "dni",
                   nroDocumento = 23235946,
                   esEmpleadoBNA = true,
                   paisOrigen = "Argentina"

                   
                }
            };

            return clientes;
        }

        [HttpGet]
        [Route("id")]
        public dynamic listarClientexid(int codigo)
        {
            //obtienes el cliente de la db

            return new Cliente
            {
                id = 2,
                nombre = "martin",
                apellido = "pena",
                cuil = "20232359464",
                tipoDocumento = "dni",
                nroDocumento = 23235946,
                esEmpleadoBNA = true,
                paisOrigen = "Argentina"
            };
        }

        [HttpPost]
        //[Route("insertar")]
        public dynamic insertarCliente(Cliente cliente)
        {
            //Guardar en la db y le asignas un id
            cliente.id = 3;

            return new
            {
                success = true,
                message = "cliente insertado",
                result = cliente
            };
        }

        [HttpPut]
        //[Route("modificar")]
        public dynamic actualizarCliente(Cliente cliente)
        {
            //Guardar en la db y le asignas un id
            cliente.id = 3;

            return new
            {
                success = true,
                message = "cliente actualizado",
                result = cliente
            };
        }

        [HttpPost]
        [Route("eliminar")]
        public dynamic eliminarCliente(Cliente cliente)
        {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
            //eliminas en la db

            if(token != "marco123.")
            {
                return new
                {
                    success = false,
                    message = "token incorrecto",
                    result = ""
                };
            }

            return new
            {
                success = true,
                message = "cliente eliminado",
                result = cliente
            };
        }
    }
}
