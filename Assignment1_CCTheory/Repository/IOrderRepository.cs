﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_CCTheory.Models;
namespace Assignment1_CCTheory.Repository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> Get(int id);
        Task Add(Order item);
        Task Remove(int id);
        Task Update(Order item);  
	
    }
}
