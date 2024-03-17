using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfBD.DTO;

namespace WfBD.Repository
{
    public interface ITypeObject
    {
        public void Insertar(TypeObjectDTO o);
        public void Modificar(TypeObjectDTO o);
        public void Eliminar(int id);
        public TypeObjectDTO Buscar(TypeObjectDTO o);
        public List<TypeObjectDTO> Listar(TypeObjectDTO o);
    }
}
