namespace CrossCutting.Models
{
    public class DatosCredenciales
    {
        public string Servidor { get; set; }
        public string BaseDatos { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool   AutenticacionWindows { get; set; }
        public string NombreEmpresa { get; set; }
        public bool GuardarDatos { get; set; }
        public string Tema { get; set; }
        public bool Dart { get; set; }
    }
}
