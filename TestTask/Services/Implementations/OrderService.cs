using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Enums;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Implementations;

public class OrderService : IOrderService
{
    private readonly ApplicationDbContext _context;

    public OrderService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<Order> GetOrder()
    {
        return await _context.Orders
            .Where(o => o.Quantity > 1)
            .OrderByDescending(o => o.CreatedAt)
            .FirstOrDefaultAsync();
    }
    
    public async Task<List<Order>> GetOrders()
    {
        return await _context.Orders
            .Include(o => o.User)
            .Where(o => o.User.Status == UserStatus.Active)
            .OrderBy(o => o.CreatedAt)
            .ToListAsync();
    }
}