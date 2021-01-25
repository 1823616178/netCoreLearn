using System.Threading.Tasks;
using aspCoew.Item.Interfaces;
using Microsoft.AspNetCore.Http;

namespace aspCoew.Middle
{
    public class nextMiddle
    {
        private readonly RequestDelegate _next;
        private readonly IGoodsInterface _goodsInterface;

        public nextMiddle(RequestDelegate next, IGoodsInterface goodsInterface)
        {
            _next = next;
            _goodsInterface = goodsInterface;
        }

        public async Task Invoke(HttpContext context)
        {
            _goodsInterface.Scope();
            await _next.Invoke(context);
        }
    }
}