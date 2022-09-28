using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecShop
{
    class ClsProducto
    {
        public int idProducto { get; set; }
        public string NomProducto { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public int stock { get; set; }
        public int precioCompra { get; set; }
        public int PrecioVenta { get; set; }


    }
}
