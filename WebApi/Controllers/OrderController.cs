using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class OrderController : Controller
    {

        IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {

            _orderService = orderService;
        }

        [HttpGet("/order/getall")]
        public IActionResult GetList()
        {
            var result = _orderService.GetList();

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpGet("/order/get")]
        public IActionResult GetById(int id)
        {
            var result = _orderService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("/order/add")]
        public IActionResult Add([FromBody] Order order)
        {

            var result = _orderService.Add(order);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("/order/update")]
        public IActionResult Update([FromBody] Order order)
        {
            var result = _orderService.Update(order);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("/order/delete")]
        public IActionResult Delete([FromBody] Order order)
        {
            var result = _orderService.Delete(order);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

    }
}
