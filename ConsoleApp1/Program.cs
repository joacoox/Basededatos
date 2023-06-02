using Google.Cloud.Firestore;
using SQLServer;
using SQLServer.Fire;




/*var alumnos = alumno.


// Conexion.Leer("2; DELETE FROM alumnos2"); borra la base de datos

foreach (var item in alumnos)
{
    Console.WriteLine(item.ToString());
}*/

// await FireConnections.Agregar("joaquin", "dominguez");

internal class Program
{
    public static async Task Main(string[] args)
    {
        /* var asd = await FireConnections.Leer();

         foreach (var item in asd)
         {
        //     Console.WriteLine($"{item.Nombre} {item.Apellido}");
         }*/

        await FireConnections.Agregar("(っ◕‿◕)っ  ", "⊙·⊙ ⊙0⊙ ⊙︿⊙ ⊙ω⊙");

        /* AlumnoFire a1 = new AlumnoFire("joaco","asd");

       AlumnoFire a2 = a1;

       a2.Nombre = "pepe";

       Console.WriteLine(a1.Nombre);*/

     //   var listener = FireConnections.TraerRealTime();

        Console.ReadLine();

    }


   
}