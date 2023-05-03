namespace NetCoreYouTube.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String cuil { get; set; }
        public String tipoDocumento { get; set; }
        public int nroDocumento { get; set; }
        public Boolean esEmpleadoBNA { get; set; }
        public String paisOrigen { get; set; }
    }
}
