using Microsoft.AspNetCore.Mvc;
using ProyectoFinalTecWeb.Entities.Dtos.Auth;
using ProyectoFinalTecWeb.Entities.Dtos.DriverDto;
using ProyectoFinalTecWeb.Entities.Dtos.PassengerDto;
using ProyectoFinalTecWeb.Services;

namespace ProyectoFinalTecWeb.Services
{
    public interface IAuthService
    {
        Task<(bool ok, LoginResponseDto? response)> LoginAsync(LoginDto dto);
        Task<string> RegisterDriverAsync(RegisterDriverDto dto);
        Task<string> RegisterPassengerAsync(RegisterPassengerDto dto);
        Task<(bool ok, LoginResponseDto? response)> RefreshAsync(RefreshRequestDto dto);

        Task<string?> ForgotPasswordAsync(string email);
        Task<bool> ResetPasswordAsync(ResetPasswordDto dto);
    }
}






