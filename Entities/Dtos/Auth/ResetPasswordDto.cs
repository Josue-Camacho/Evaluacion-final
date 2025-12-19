namespace ProyectoFinalTecWeb.Entities.Dtos.Auth
{
    public class ResetPasswordDto
    {
        public string Token { get; set; }
        public string NewPassword { get; set; }
    }
}
