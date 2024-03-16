using Repository;


// Ruta del archivo para almacenar empleados
string archivoEmpleados = "empleados.txt";

// Crear una instancia del repositorio de empleados
// utilizando el archivo
IEmpleadoRepository productoRepository
    = new EmpleadoRepositoryArchivo(archivoEmpleados);

// Crear una instancia del gestor de empleados 
// utilizando el repositorio
GestorEmpleados gestorEmpleados
    = new GestorEmpleados(productoRepository);

// Agregar algunos empleados de ejemplo
gestorEmpleados.AgregarProducto(
    new Empleado { Nombre = "Pepe", Edad = 18, Cargo = "Director", Telefono = 77222342, Carnet = "2023-0921u" });

// Mostrar todos los empleados
Console.WriteLine( "Todos los empleados:");
foreach (var empleado in gestorEmpleados.ObtenerTodosLosProductos())
    Console.WriteLine( $"Nombre: {empleado.Nombre}, " +
        $"Edad: {empleado.Edad},  " + $"Cargo : {empleado.Cargo}, " +
        $"Telefono : {empleado.Telefono} , " +  $"Carnet : {empleado.Carnet}" );

