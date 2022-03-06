using AsignacionLab2.Edu.Interfaces;

namespace AsignacionLab2.Edu.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string Cui { get; set; }
        public string Cargo { get; set; }

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