using Microsoft.Extensions.Configuration;
using MyChatGPT;
using Refit;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var completionsApi = RestService.For<ICompletionsAPI>("https://api.openai.com", new RefitSettings
{
    AuthorizationHeaderValueGetter = () => Task.FromResult(config["ApiKey"] ?? string.Empty),
});

Console.WriteLine("Welcome to MyChatGPT! Please, enter a prompt:");

while (true)
{
    Console.Write(">>> ");

    string? userPrompt = Console.ReadLine();

    CompletionResponse response = await completionsApi.CreateCompletion(new CompletionRequest
    {
        Prompt = userPrompt
    });

    ChoiceCompletionResponse? choice = response.Choices.FirstOrDefault();

    Console.WriteLine(choice?.Text);
}