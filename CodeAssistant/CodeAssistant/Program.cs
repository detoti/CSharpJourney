using System;
using System.Threading.Tasks;
using OpenAI;

class Program
{
    static async Task Main(string[] args)
    {

        string apiKey = "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";
        OpenAIApi openAiApi = new OpenAIApi(apiKey);

        Console.WriteLine("Bem-vindo ao Chatbot de Teste!");
        Console.WriteLine("Digite sua mensagem para obter uma resposta:");

        string userInput = Console.ReadLine();

        var prompt = userInput;
        var result = await openAiApi.Completions.CreateCompletion(prompt, model: "text-davinci-003", max_tokens: 50);

        string response = result.Choices[0].Text.Trim();
        Console.WriteLine("\nResposta do Chatbot:");
        Console.WriteLine(response);
    }
}
