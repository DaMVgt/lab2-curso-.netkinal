using AsignacionLab2.Edu.Entities;

public class Program
{
    private static List<Persona> ListaGeneral = new(); 
    public static void Main(string[] args)
    {

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

    public static void QuitarAsignatura(Persona elemento)
    {
        if(elemento is Profesor)
        {
            ((Profesor)elemento).EliminarAsignatura("");
        } else if ( elemento is Alumno)
        {
            ((Alumno)elemento).EliminarAsignatura(""); 
        }
    }
}