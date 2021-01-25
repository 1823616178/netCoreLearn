using System;
using System.Threading.Tasks;
using aspCoew.Item.domain;
using aspCoew.Middle.filter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspCoew.Controllers
{
    [ServiceFilterAttribute(typeof(AddHeaderResultServiceFilter))]
    public class OnePageController:Controller
    {
        public OnePageController()
        {
            
        }
        
        [ControllerActionFilter]
        public async void getPageInfo()
        {
            object data = typeof(Goods);
            await Response.WriteAsync("hello World");
        }
    }
}