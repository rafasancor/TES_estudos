var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá, Rafael");

app.MapGet("/sobre", () => "Olá, Sou estudante");

app.MapGet("/localizacao", () => "Olá, Sou de Curitiba");

app.MapGet("/contato", () => "Olá, me procure por @rafasancor");

app.MapGet("/servicos", () => "Olá, Consigo analisar e desenvolver pra você");

app.MapGet("/agora", () => $"Data e hora atual: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");

app.MapGet("/ano", () => $"Ano atual: {DateTime.Now.Year}");

app.MapGet("/dia", () =>
    $"Hoje é: {DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("pt-BR"))}");

app.Run();
