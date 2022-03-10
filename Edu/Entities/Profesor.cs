using AsignacionLab2.Edu.Interfaces;

namespace AsignacionLab2.Edu.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string Cui { get; set; }
        public string Cargo { get; set; }

        public override void TomarAsistencia()
        {

        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura del profesor: {this.Apellidos}, {this.Nombres}");
            return true;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.Write($"UUID: {this.Uuid} \nApellidos: {this.Apellidos} \nNombres: {this.Nombres} \nCargo: {this.Cargo}"); 
        }

        public Profesor () : base()
        {
            this.Cui = "";
            this.Cargo = ""; 
        }

        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
            : base(uuid,apellidos,nombres,email)
        {
            this.Cui = cui;
            this.Cargo = cargo;
        }
    }
}