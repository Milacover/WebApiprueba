﻿using APIService.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IOrderService _orderService;
        public OrderController(ILogger<ProductController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpPost(Name = "InsertOrder")]
        public int Post([FromBody] OrderItem orderItem)
        {
            return _orderService.InsertOrder(orderItem);
        }

        [HttpPatch(Name = "PatchOrder")]
        public int Put([FromBody] OrderItem orderItem)
        {
            return _orderService.PatchOrder(orderItem);
        }


        [HttpGet(Name = "GetOrder")]
        //nombreSitio.com/nombreController/id
        public List<OrderItem> Get()
        {
            return _orderService.GetOrder();
        }


        [HttpDelete(Name = "DeleteOrder")]
        public void DeleteById(int id)
        {
            _orderService.DeleteOrderById(id);
        }
    }
}
