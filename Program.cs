
namespace calificacion
{
  class Program
  {
    static void Main(string[] args)
    {
      int notas = 0;
      int opc = 0;
      int[] calificacionesEscolares = new int[notas];
      string [] materia = new string[notas];


      Console.WriteLine("----Nota Escolar-----");
      do
      {
        try
        {
          while (opc != 4)
          {
            Console.WriteLine(
            "\n 1: Ingresar calificaciones " +
            "\n 2: Ver calificaciones " +
            "\n 3: Ver promedio de calificaciones " +
            "\n 4: Salir");
            opc = int.Parse(Console.ReadLine());     
            switch (opc)
            {
              
              case 1:
                Console.Clear();
                Console.WriteLine("Cuantas notas desea ingresar?");
                notas = int.Parse(Console.ReadLine());
                materia = NombreDeLaMateria(notas);
                calificacionesEscolares = IngresarNotas(notas, materia);
              
                break;
                
              case 2:
                Console.Clear();
                VerCalificaciones(calificacionesEscolares, materia);
                break;
              case 3:
                Console.Clear();
                Console.WriteLine($"El promedio de todas sus calificaciones es: {PromedioCalificaciones(calificacionesEscolares)}");
                break;
              case 4:
                Console.Clear();
                Salir();
                break;
              default:
                throw new Exception();
                
            }
          }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
      } while (opc != 4);
    }

    public static string[] NombreDeLaMateria(int asg)
        {
            string [] asignatura = new string[asg];
            for (int i = 0; i < asignatura.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre de su {i+1} asignatura");
                asignatura[i] = Console.ReadLine();
            }
            return asignatura;
        }


    // metodo para ingresar notas
    public static int[] IngresarNotas(int notas, string[] asignatura)
    {

      int[] array = new int[notas];
     
      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine($"Ingrese la nota de la asignatura: {asignatura[i]}");
        array[i] = int.Parse(Console.ReadLine());
      }

      Console.WriteLine("Sus notas se agregaron correctamente");

      return array;
    }

    

    // metodo para ver las calificaciones

    public static void VerCalificaciones(int[] nota, string [] asignatura)
    {
      for (int i = 0; i < nota.Length; i++)
      {
        Console.WriteLine($"{asignatura[i]} = {nota[i]} de calificacion final");
      }

    }

    // metodo para saber el promedio de calificaciones
    public static int PromedioCalificaciones(int[] calificacion)
    {
      int suma = 0;
      int promedio = 0;
      int cantNotas = 0;

      for (int i = 0; i < calificacion.Length; i++)
      {
        suma = suma + calificacion[i];
        cantNotas++;
      }
      promedio = suma / cantNotas;
      return promedio;

    }

    // metodo para salir del programa
    public static void Salir()
    {
      Console.WriteLine("Thanks, for used our system");
    }
  }

}