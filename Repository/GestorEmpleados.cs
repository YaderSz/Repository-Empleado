using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GestorEmpleados
    {
        private IEmpleadoRepository _repository;

        public GestorEmpleados(
            IEmpleadoRepository repository) 
        {
            _repository = repository;
        }

        public List<Empleado> ObtenerTodosLosProductos()
        {
            return _repository.ObtenerTodos();
        }

        public void AgregarProducto(Empleado empleado)
        {
            List<Empleado> empleados 
                = _repository.ObtenerTodos();
            empleados.Add(empleado);
            _repository.GuardarTodos(empleados);
        }
    }
}
