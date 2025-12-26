using System.ComponentModel.DataAnnotations;

namespace GameStore.Dtos;

public record class CreateGameDto
(
    [Required][StringLength(50)]string Name, 
    [Required][StringLength(20)]string Genre, 
    [Required][Range(1, 1000)]decimal Price,
    DateOnly ReleaseDate
);