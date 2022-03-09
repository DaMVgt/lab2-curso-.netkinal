namespace AsignacionLab2.Edu.Entities
{
    public class Persona
    {
        public string Uuid { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }

        public void TomarAsistencia()
        {

        }

        public Persona()
        {
        }

        public Persona(string uuid, string apellidos, string nombres, string email)
        {
            this.Uuid = uuid;
            this.Apellidos = apellidos;
            this.Nombres = nombres;
            this.Email = email;
        }
    }
}