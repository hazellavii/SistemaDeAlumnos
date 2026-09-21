// ETAPA 8 //

List<Persona> personas = new List<Persona>
{
    new Alumno("Abi", 40123456, 1234),
    new Profesor("Venecia", 40987654, "Programación"),
    new Preceptor("Luchi", 40777888, "Segundo año")
};

foreach (Persona persona in personas)
{
    Console.WriteLine(persona.Presentarse());
}

Console.WriteLine();

// Al quitar virtual de aparecen 3 errores:
// Alumno, Profesor y Preceptor no podían usar override porque el método de Persona ya no era virtual.


// ETAPA 6 //

List<Alumno> alumnos = new List<Alumno>();

bool continuar = true;

while (continuar)
{
    Console.WriteLine();
    Console.WriteLine("----- SISTEMA DE ALUMNOS -----");
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar alumno por legajo");
    Console.WriteLine("4. Mostrar promedio general");
    Console.WriteLine("5. Mostrar cantidad de aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Elegí una opción: ");

    string opcion = Console.ReadLine() ?? "";

    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";
            
            Console.Write("Documento: ");
            bool documentoValido = int.TryParse(Console.ReadLine(), out int documento);

            Console.Write("Legajo: ");
            bool legajoValido = int.TryParse(Console.ReadLine(), out int legajo);

            Console.Write("Nota 1: ");
            bool nota1Valida = double.TryParse(Console.ReadLine(), out double nota1);

            Console.Write("Nota 2: ");
            bool nota2Valida = double.TryParse(Console.ReadLine(), out double nota2);


            if (!documentoValido || !legajoValido || !nota1Valida || !nota2Valida)
            {
                Console.WriteLine("Los datos ingresados no son válidos.");
                break;
            }

            Alumno nuevoAlumno = new Alumno(nombre, documento, legajo);
            
            bool notasCargadas = nuevoAlumno.CargarNotas(nota1, nota2);

            if (!notasCargadas)
            {
                Console.WriteLine("Las notas deben estar entre 0 y 10.");
                break;
            }

            alumnos.Add(nuevoAlumno);
            Console.WriteLine("Alumno agregado correctamente.");
            break;

        case "2":
            if (alumnos.Count == 0)
            {
                Console.WriteLine("Todavía no hay alumnos cargados.");
                break;
            }

            Console.WriteLine("Lista de alumnos:");

            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno);
            }

            break;

        case "3":
            Console.Write("Ingresá el legajo que querés buscar: ");

            if (!int.TryParse(Console.ReadLine(), out int legajoBuscado))
            {
                Console.WriteLine("El legajo ingresado no es válido.");
                break;
            }

            Alumno? alumnoEncontrado = null;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Legajo == legajoBuscado)
                {
                    alumnoEncontrado = alumno;
                    break;
                }
            }

            if (alumnoEncontrado == null)
            {
                Console.WriteLine("No existe un alumno con ese legajo.");
            }
            else
            {
                Console.WriteLine(alumnoEncontrado);
            }

            break;

        case "4":
            if (alumnos.Count == 0)
            {
                Console.WriteLine("No se puede calcular el promedio porque no hay alumnos.");
                break;
            }

            double sumaPromedios = 0;

            foreach (Alumno alumno in alumnos)
            {
                sumaPromedios += alumno.Promedio();
            }

            double promedioGeneral = sumaPromedios / alumnos.Count;

            Console.WriteLine($"Promedio general del curso: {promedioGeneral}");
            break;

        case "5":
            int cantidadAprobados = 0;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.EstaAprobado())
                {
                    cantidadAprobados++;
                }
            }

            Console.WriteLine($"Cantidad de alumnos aprobados: {cantidadAprobados}");
            break;

        case "6":
            continuar = false;
            Console.WriteLine("Programa finalizado.");
            break;

        default:
            Console.WriteLine("La opción ingresada no existe.");
            break;
    }
}