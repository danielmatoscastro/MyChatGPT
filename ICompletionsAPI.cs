using Refit;

namespace MyChatGPT;

[Headers("Authorization: Bearer")]
public interface ICompletionsAPI
{
    [Post("/v1/completions")]
    Task<CompletionResponse> CreateCompletion(CompletionRequest request);
}