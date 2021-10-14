using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.MetodosInventario
{
    public class UEPS : IMetodosModel
    {
        private Producto[] productos;

        public void Compra(int i)
        {
           
        }

        public decimal CostoCompra()
        {
            decimal CostoCompra = 0;  
            return CostoCompra = productos[productos.Length].Existencia * productos[productos.Length].Precio;
        }

        public decimal CostoTotal()
        {
            decimal CostoCompras = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                CostoCompras += productos[i].Existencia * productos[i].Precio;
            }
            return CostoCompras;
        }

        public void Create(Producto p)
        {
             if(p == null)
             {
                
             }
            if(productos == null)
            {
                productos = new Producto[1];
                productos[0] = p;
            }
            else
            {
                Producto[] tmp = new Producto[productos.Length - 1];
                Array.Copy(productos, tmp, productos.Length - 1);
                tmp[tmp.Length - 1] = p;
                productos = tmp;
            }
        }

        public void Delete(Producto p)
        {
            if(p.Existencia == 0)
            {
                Producto[] tmp = new Producto[productos.Length - 1];
                Array.Copy(productos, tmp, productos.Length);
                productos = tmp;
            }
        }

        public void Venta(int i)
        {
            throw new NotImplementedException();
        }
    }
}
