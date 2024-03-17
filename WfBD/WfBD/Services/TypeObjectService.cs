using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfBD.DTO;
using WfBD.Models;
using WfBD.Repository;
using System.Linq;
using System;
using System.Collections.Generic;

namespace WfBD.Services
{
    internal class TypeObjectService : ITypeObject
    {

        public void Insertar(TypeObjectDTO o)
        {
            using (var context = new WarframeProyectContext())
            {
                // Crear nueva instancia de TypeObject
                var newTypeObject = new TypeObject
                {
                    TypeObject1 = o.typeObject
                };

                // Agregar TypeObject al contexto
                context.TypeObjects.Add(newTypeObject);
                context.SaveChanges();
            }
        }

        public void Modificar(TypeObjectDTO o)
        {
            using (var context = new WarframeProyectContext())
            {
                // Buscar TypeObject existente en el contexto
                var typeObject = context.TypeObjects.Find(o.TypeObjectId);

                if (typeObject == null)
                {
                    throw new Exception("TypeObject no encontrado");
                }

                // Actualizar propiedades de TypeObject
                typeObject.TypeObject1 = o.typeObject;

                // Guardar cambios en el contexto
                context.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var context = new WarframeProyectContext())
            {
                // Buscar TypeObject existente en el contexto
                var typeObject = context.TypeObjects.Find(id);

                if (typeObject == null)
                {
                    throw new Exception("TypeObject no encontrado");
                }

                // Eliminar TypeObject del contexto
                context.TypeObjects.Remove(typeObject);
                context.SaveChanges();
            }
        }

        public TypeObjectDTO Buscar(TypeObjectDTO o)
        {
            using (var context = new WarframeProyectContext())
            {
                // Buscar TypeObject por ID en el contexto
                var typeObject = context.TypeObjects.Find(o.TypeObjectId);

                // Convertir TypeObject a TypeObjectDTO (o manejar de otra manera)
                var typeObjectDto = new TypeObjectDTO
                {
                    TypeObjectId = typeObject.TypeObjectId,
                    typeObject = typeObject.TypeObject1
                };

                return typeObjectDto;
            }
        }

        public List<TypeObjectDTO> Listar(TypeObjectDTO o)
        {
            using (var context = new WarframeProyectContext())
            {
                // Obtener todos los TypeObjects del contexto
                var typeObjects = context.TypeObjects.ToList();

                // Convertir TypeObjects a TypeObjectDTOs (o manejar de otra manera)
                var typeObjectsDto = typeObjects.Select(to => new TypeObjectDTO
                {
                    TypeObjectId = to.TypeObjectId,
                    typeObject = to.TypeObject1
                }).ToList();

                return typeObjectsDto;
            }
        }

    }
}
