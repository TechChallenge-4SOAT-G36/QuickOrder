﻿using Microsoft.AspNetCore.Mvc;
using QuickOrder.Core.Application.Dtos;
using QuickOrder.Core.Application.UseCases.Pedido.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuickOrder.Adapters.Driving.Api.Controllers.Pedido
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : CustomController<PedidoController>
    {

        private readonly IPedidoObterUseCase _pedidoObterUseCase;
        private readonly IPedidoCriarUseCase _pedidoCriarUseCase;
        private readonly IPedidoAtualizarUseCase _pedidoAtualizarUseCase;
        private readonly IPedidoExcluirUseCase _pedidoExcluirUseCase;

        public PedidoController(ILogger<PedidoController> logger,
            IPedidoObterUseCase pedidoObterUseCase,
            IPedidoCriarUseCase pedidoCriarUseCase,
            IPedidoAtualizarUseCase pedidoAtualizarUseCase,
            IPedidoExcluirUseCase pedidoExcluirUseCase) : base(logger)
        {
            _pedidoObterUseCase = pedidoObterUseCase;
            _pedidoCriarUseCase = pedidoCriarUseCase;
            _pedidoAtualizarUseCase = pedidoAtualizarUseCase;
            _pedidoExcluirUseCase = pedidoExcluirUseCase;
        }

        /// <summary>
        /// Consulta pedido pelo número
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("consultarpedido/{id}")]
        public async Task<IActionResult> ConsultarPedido(int id)
        {
            return Result(await _pedidoObterUseCase.ConsultarPedido(id));
        }

        /// <summary>
        /// Consulta Fila de pedidos não finalizados
        /// </summary>
        /// <returns></returns>
        [HttpGet("consultarfilapedidos")]
        public async Task<IActionResult> ConsultarFilaPedidos()
        {
            return Result(await _pedidoObterUseCase.ConsultarFilaPedidos());
        }

        /// <summary>
        /// Confirma pedido 
        /// </summary>
        /// <param name="numeroPedido"></param>
        /// <returns></returns>
        [HttpPost("criarpedido")]
        public async Task<IActionResult> CriarPedido(int numeroCliente)
        {
            return Result(await _pedidoCriarUseCase.CriarPedido(numeroCliente));
        }

        /// <summary>
        /// Adicionar item ao Pedido
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pedidoDto"></param>
        /// <returns></returns>
        [HttpPut("adicionaritemaopedido/{id}")]
        public async Task<IActionResult> AlterarItemAoPedido(string id, [FromBody] PedidoDto pedidoDto)
        {
            return Result(await _pedidoAtualizarUseCase.AlterarItemAoPedido(id, pedidoDto));
        }

        /// <summary>
        /// Confirma pedido 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("confirmapedido/{id}")]
        public async Task<IActionResult> ConfirmarPedido(int id)
        {
            return Result(await _pedidoAtualizarUseCase.ConfirmarPedido(id));
        }

        /// <summary>
        /// Confirma pagamento do pedido 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("confirmapagamentopedido/{id}")]
        public async Task<IActionResult> ConfirmarPagamentoPedido(int id)
        {
            return Result(await _pedidoAtualizarUseCase.ConfirmarPagamentoPedido(id));
        }

        /// <summary>
        /// Alterar status do Pedido
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpPut("alterarstatuspedido/{id}")]
        public async Task<IActionResult> AlterarStatusPedido(string id, [FromBody] PedidoStatusDto pedidoStatusDto)
        {
            return Result(await _pedidoAtualizarUseCase.AlterarStatusPedido(id, pedidoStatusDto));
        }

        /// <summary>
        /// Cancelar pedido não confirmados
        /// </summary>
        /// <param name="carrinhoId"></param>
        /// <returns></returns>
        [HttpDelete("cancelarpedido/{carrinhoId}")]
        public async Task<IActionResult> CancelarPedido(string carrinhoId)
        {
            return Result(await _pedidoExcluirUseCase.CancelarPedido(carrinhoId));
        }
    }
}
