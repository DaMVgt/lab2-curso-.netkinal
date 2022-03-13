using AsignacionLab2.Edu.Interfaces;

namespace AsignacionLab2.Edu.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public string NumeroCreditos { get; set; }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Se registro asistencia de alumno con Carne: {this.Carne}");
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de {this.Apellidos}, {this.Nombres}. Se perdera la cantidad de creditos {this.NumeroCreditos}");
            return true;
        }

        public void ListarMisDatos(string identificar)
        {
            Console.WriteLine($"UUID: {this.Uuid} \nApellidos: {this.Apellidos} \nNombres: {this.Nombres} \nCargo: {this.NumeroCreditos}");
        }

        public Alumno () : base()
        {
        }
        
        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, string numeroCreditos)
            : base(uuid,apellidos,nombres,email)
        {  
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }
    }
}