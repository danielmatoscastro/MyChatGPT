namespace MyChatGPT;

using System.Text.Json.Serialization;

public class CompletionRequest
{
    public string Model { get; set; } = "text-davinci-003";
    public string? Prompt { get; set; }
    public double Temperature { get; set; } = 0;

    [JsonPropertyName("max_tokens")]
    public int MaxTokens { get; set; } = 2048;
}