using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfBD.DTO;

namespace WfBD.Repository
{
    public interface IObject
    {
        public void Insertar(ObjectDTO o);
        public void Modificar(ObjectDTO o);
        public void Eliminar(int id);
        public ObjectDTO Buscar(ObjectDTO o);
        public List<ObjectDTO> Listar(ObjectDTO o);

    }
}
