// ETAPA 5 //

Alumno alumno1 = new Alumno("Abi", 1234);
Alumno alumno2 = new Alumno("Juli", 5678);

bool notasAbi = alumno1.CargarNotas(8, 6);

if (!notasAbi)
{
    Console.WriteLine("Las notas de Abi son inválidas.");
}

bool notasJuli = alumno2.CargarNotas(47, 7);

if (!notasJuli)
{
    Console.WriteLine("Las notas de Juli son inválidas.");
}

// 
alumno2.CargarNotas(5, 7);

Console.WriteLine(alumno1);
Console.WriteLine(alumno2);