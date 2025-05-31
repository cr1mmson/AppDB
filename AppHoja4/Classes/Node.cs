using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHoja4.Classes
{
    internal class Node
    {

        public Node Next { get; set; }
        public Node Prev { get; set; }
        public long DPI { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public long Telefono { get; set; }
        public string correoElectronico { get; set; }
        public Node(Node Next, Node Previous, long dpi, string nombre, string fecha, long telefono, string correoElectronico)
        {
            this.DPI = dpi;
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.Next = Next;
            this.Prev = Previous;
        }

        public Node(long dpi, string nombre, string fecha, long telefono, string correoElectronico)
        {
            this.DPI = dpi;
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.Next = null;
            this.Prev = null;
        }

    }
}
