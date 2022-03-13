using AsignacionLab2.Edu.Entities;

public class Program
{
    private static List<Persona> ListaGeneral = new List<Persona>(); 
    public static void Main(string[] args)
    {
        Alumno JuanPerez = new Alumno("12123", "Perez Alvarez", "Juan Alberto", "jperez@kalum.edu.gt", "2022001", "30");
        Profesor JuanGonzales = new Profesor("312", "Gonzales Perez", "Juan Antonio", "jgonzales@kalum.edu.gt", "1239873460101","Instructor");

        OperarRegistro(JuanPerez);
        OperarRegistro(JuanGonzales);

        Console.WriteLine("---------Registrando Asistencias----------");
        RegistrarAsistencia(JuanPerez);
        RegistrarAsistencia(JuanGonzales);

        Console.WriteLine("---------Datos General----------");
        VerMisDatos(JuanPerez);
        Console.WriteLine("---------Datos General----------");
        VerMisDatos(JuanGonzales);

        Console.WriteLine("--------------------------------");
        QuitarAsignatura(JuanPerez, "Matematica");
        QuitarAsignatura(JuanGonzales, "Informatica");
    }

    public static void OperarRegistro(Persona elemento)
    {
        Program.ListaGeneral.Add(elemento); 
    }

    public static void RegistrarAsistencia(Persona elemento)
    {
        elemento.TomarAsistencia(); 
    }

    public static void VerMisDatos(Persona elemento)
    {
        if (elemento is Profesor)
        {
            ((Profesor)elemento).ListarMisDatos(((Profesor)elemento).Cui);
        }
        else if (elemento is Alumno)
        {
            ((Alumno)elemento).ListarMisDatos(((Alumno)elemento).Carne); 
        }
    }

    public static void QuitarAsignatura(Persona elemento, string asignatura)
    {
        if(elemento is Profesor)
        {
            ((Profesor)elemento).EliminarAsignatura(asignatura);
        } else if ( elemento is Alumno)
        {
            ((Alumno)elemento).EliminarAsignatura(asignatura); 
        }
    }
}