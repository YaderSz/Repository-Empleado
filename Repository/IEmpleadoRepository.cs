using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    // Repositorio de empleados
    public interface IEmpleadoRepository
    {
        List<Empleado> ObtenerTodos();
        void GuardarTodos(List<Empleado> empleados);
    }
}
