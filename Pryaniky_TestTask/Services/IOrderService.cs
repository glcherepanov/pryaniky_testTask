using Microsoft.AspNetCore.Mvc;
using Pryaniky_TestTask.Models;

namespace Pryaniky_TestTask.Services
{
    public interface IOrderService
    {
        public Order Create(int productId);
        public IActionResult Remove(int id);
    }
}
