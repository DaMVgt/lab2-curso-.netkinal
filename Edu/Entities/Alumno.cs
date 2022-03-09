using AsignacionLab2.Edu.Interfaces;

namespace AsignacionLab2.Edu.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public string NumeroCreditos { get; set; }

        public bool EliminarAsignatura()
        {
            Console.WriteLine($"Se ha eliminado la asignatura de {this.Apellidos}, {this.Nombres}. Se perdera la cantidad de creditos {this.NumeroCreditos}");
            return true;
        }

        public void ListarMisDatos()
        {
            throw new NotImplementedException();
        }

        public Alumno () : base()
        {
        }
        
        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, string numeroCreditos)
            : base()
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }
    }
}