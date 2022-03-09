using AsignacionLab2.Edu.Interfaces;

namespace AsignacionLab2.Edu.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string Cui { get; set; }
        public string Cargo { get; set; }

        public bool EliminarAsignatura()
        {
            Console.WriteLine($"Se ha eliminado la asignatura del profesor: {this.Apellidos}, {this.Nombres}");
            return true;
        }

        public void ListarMisDatos()
        {
            throw new NotImplementedException();
        }

        public Profesor () : base()
        {
        }

        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
            : base()
        {
            this.Cui = cui;
            this.Cargo = cargo;
        }
    }
}