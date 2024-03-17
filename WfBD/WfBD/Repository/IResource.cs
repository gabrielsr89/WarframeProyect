using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfBD.DTO;

namespace WfBD.Repository
{
    public interface IResource
    {
        public void Insertar(ResourceDTO o);
        public void Modificar(ResourceDTO o);
        public void Eliminar(int id);
        public ResourceDTO Buscar(ResourceDTO o);
        public List<ResourceDTO> Listar(ResourceDTO o);
    }
}
