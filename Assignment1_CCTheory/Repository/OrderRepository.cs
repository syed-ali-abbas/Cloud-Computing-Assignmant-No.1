using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Assignment1_CCTheory.Models;
using System.Data.Entity;

namespace Assignment1_CCTheory.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SqlDBContext db = new SqlDBContext();
        public async Task Add(Order item)
        {
            item.OrdId = int.Parse(Guid.NewGuid().ToString());
            db.Orders.Add(item);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Order> Get(int id)
        {
            try
            {
                Order order = await db.Orders.FindAsync(id);
                if (order == null)
                {
                    return null;
                }
                return order;
            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<Order>> GetAll()
        {
            try
            {
                var order = await db.Orders.ToListAsync();
                return order.AsQueryable();
            }
            catch
            {
                throw;
            }
        }
        public async Task Remove(int id)
        {
            try
            {
                Order order = await db.Orders.FindAsync(id);
                db.Orders.Remove(order);
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task Update(Order item)
        {
            try
            {
                db.Entry(item).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.OrdId == id) > 0;
        }
    }
}