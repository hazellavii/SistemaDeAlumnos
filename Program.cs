// ETAPA 3 //

/////A1
Alumno alumno1 = new Alumno("Brookie", 1234, 8, 6);
Alumno alumno2 = new Alumno("Luchi", 5678, 4, 5);

Console.WriteLine(alumno1.Nombre + " - Promedio: " + alumno1.Promedio());
Console.WriteLine("¿Está aprobada? " + alumno1.EstaAprobado());

Console.WriteLine();

Console.WriteLine(alumno2.Nombre + " - Promedio: " + alumno2.Promedio());
Console.WriteLine("¿Está aprobada? " + alumno2.EstaAprobado());

/////A2
alumno2.SubirNota();

Console.WriteLine();
Console.WriteLine("Notas de Luchi después de subirlas:");
Console.WriteLine("Nota 1: " + alumno2.Nota1);
Console.WriteLine("Nota 2: " + alumno2.Nota2);
Console.WriteLine("Nuevo promedio: " + alumno2.Promedio());
Console.WriteLine("¿Está aprobada? " + alumno2.EstaAprobado());