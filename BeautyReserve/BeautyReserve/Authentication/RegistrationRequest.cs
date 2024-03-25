using System.ComponentModel.DataAnnotations;

namespace BeautyReserve.Authentication;

public record RegistrationRequest
(
    [Required] string Email,
    [Required] string UserName,
    [Required] string Password,
    [Required] string Role
);