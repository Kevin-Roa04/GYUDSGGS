using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IMetodosInventario<T>
    {
        void Venta();
        void Compra(T t);
        void Delete();
        void Create();
    }
}
