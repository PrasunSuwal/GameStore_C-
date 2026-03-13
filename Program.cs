using GameStore.Api.DTOs;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

List<GameDto> games = [
    new (1, "Street Fighter II", "Fighting", 19.99M, new DateOnly(1992, 7, 15)),
    new (2, "The Legend of Zelda: Ocarina of Time", "Adventure", 12.00M, new DateOnly(1998, 11, 21)),
    new (3, "Super Mario Bros.", "Platformer", 40.24M, new DateOnly(1985, 9, 13))
];

// GET /games
app.MapGet("/games", () => games);

app.Run();
