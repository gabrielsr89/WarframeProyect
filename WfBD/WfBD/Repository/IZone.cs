using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfBD.DTO;

namespace WfBD.Repository
{
    public interface IZone
    {
        public void Insertar(ZoneDTO o);
        public void Modificar(ZoneDTO o);
        public void Eliminar(int id);
        public ZoneDTO Buscar(ZoneDTO o);
        public List<ZoneDTO> Listar(ZoneDTO o);
    }
}
