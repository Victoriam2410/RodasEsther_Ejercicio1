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
if (temperatura >0 &&  presion > 0 && edad > 0 &&  dolor > 0 && oxigeno > 0 && option >=1 && option <=4)
{
    switch (option)
    {
        case 1:
        break;
    }
}
