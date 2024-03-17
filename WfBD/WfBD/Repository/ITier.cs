using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfBD.DTO;

namespace WfBD.Repository
{
    public interface ITier
    {
        public void Insertar(TierDTO o);
        public void Modificar(TierDTO o);
        public void Eliminar(int id);
        public TierDTO Buscar(TierDTO o);
        public List<TierDTO> Listar(TierDTO o);
    }
}
