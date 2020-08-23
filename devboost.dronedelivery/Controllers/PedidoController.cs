using devboost.dronedelivery.DTO;
using devboost.dronedelivery.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace devboost.dronedelivery.Controllers
{
    public class PedidoController : Controller
    {
        readonly PedidoService _pedidoService;

        public PedidoController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PedidoDTO pedidoDto)
        {
            try
            {
                var result = await _pedidoService.RealizarPedido(pedidoDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
