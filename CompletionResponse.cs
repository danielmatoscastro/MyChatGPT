namespace MyChatGPT;

public class CompletionResponse
{
    public IEnumerable<ChoiceCompletionResponse> Choices { get; set; } = new List<ChoiceCompletionResponse>();
}