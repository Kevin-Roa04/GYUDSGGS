using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IMetodosModel : IMetodosInventario<Producto>
    {
        decimal CostoTotal();
    }
}
