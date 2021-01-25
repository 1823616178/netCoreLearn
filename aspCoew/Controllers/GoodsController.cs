using aspCoew.Item.domain;
using aspCoew.Item.Interfaces;
using aspCoew.Middle.filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspCoew.Controllers
{
    [ServiceFilter(typeof(AddHeaderResultServiceFilter))]
    [Route("")]
    [ApiController]
    public class GoodsController:Controller,IGoodsInterface
    {
        private readonly ILogger _logger;
        public GoodsController(ILogger<Goods> logger)
        {
            _logger = logger;
        }
        public void Scope()
        {
            Goods goods = new Goods{Name = 3};
            _logger.LogInformation(goods.Name.ToString());
        }
        [ControllerActionFilter]
        [HttpGet, Route("")]
        public IActionResult Get()
        {
            return Content($"standard");
        }
    }
}