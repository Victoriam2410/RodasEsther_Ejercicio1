Console.WriteLine("cual es su Tipo de atención\r\n1. Emergencia\r\n2. Consulta\r\n3. Pediatría\r\n4. Traumatología");
int option = int .Parse(Console.ReadLine());
Console.WriteLine("ingrese la edad del paciente");
int edad = int .Parse(Console.ReadLine());
Console.WriteLine("ingrese la temperatura del paciente");
int temperatura = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese la saturación de oxígeno del paciente");
int oxigeno = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el nivel de dolor (0–10) del paciente");
int dolor = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese la presión sistólica del paciente");
int presion = int.Parse(Console.ReadLine());
if (temperatura >0 &&  presion > 0 && edad > 0 &&  dolor >= 0 && dolor <=10 && oxigeno > 0 && option >=1 && option <=4)
{
    switch (option)
    {
        case 1:
            if (oxigeno < 90)
            {
                Console.WriteLine("El paciente es prioridad 1 (prioridad mayor)");
            }
            else if (temperatura>=39 && dolor >=8)
            {
                Console.WriteLine("El paciente es prioridad 2 (prioridad media)");
            }
            else
            {
                Console.WriteLine("El paciente es prioridad 3 (prioridad minima)");
            }
        break;

        case 2:
            if (dolor <=3 && temperatura <=38)
            {
                Console.WriteLine("Es prioridad minima, consulta programada");
            }
            else
            {
                Console.WriteLine("Prioridad media y atención en el día");
            }

            break;
        case 3:
            if (edad < 12 && temperatura >= 38.5)
            {
                Console.WriteLine("Prioridad mayor y observación pediátrica inmediata");
            }
            else
            {
                Console.WriteLine("Prioridad media y consulta pediátrica");
            }
            break;
        case 4: 
            if (dolor >= 7 || presion < 90)
            {
                Console.WriteLine("Prioridad mayor y atención traumatológica inmediata");
            }
            else
            {
                Console.WriteLine("Prioridad media y consulta traumatológica");
            }
            break;
        default:
            Console.WriteLine("Tipo de atención inválido.");
            break;
    }
}
else
{
    Console.WriteLine("Dato invalido");
}


