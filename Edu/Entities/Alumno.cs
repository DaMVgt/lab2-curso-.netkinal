using AsignacionLab2.Edu.Interfaces;

namespace AsignacionLab2.Edu.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public string NumeroCreditos { get; set; }

        public bool EliminarAsignatura()
        {
            throw new NotImplementedException();
        }

        public void ListarMisDatos()
        {
            throw new NotImplementedException();
        }
    }
}