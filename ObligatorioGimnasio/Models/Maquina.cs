using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioGimnasio
{
    public class Maquina
    {
        public int Id { get; set; }
        public int LocalId { get; set; }
        public DateTime FechaCompra {  get; set; }
        public decimal PrecioCompra { get; set; }
        public int VidaUtil {  get; set; }
        public bool Disponible { get; set; }    

    }
}
