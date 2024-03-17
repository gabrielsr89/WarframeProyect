using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfBD.DTO;

namespace WfBD.Repository
{
    public interface IRzo
    {
        public void Insertar(RzoDTO o);
        public void Modificar(RzoDTO o);
        public void Eliminar(int id);
        public RzoDTO Buscar(RzoDTO o);
        public List<RzoDTO> Listar(RzoDTO o);
    }
}
