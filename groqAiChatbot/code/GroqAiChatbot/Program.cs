using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    private static readonly HttpClient client = new HttpClient();
    private const string apiKey = "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"; // Replace with your actual API key
    private const string apiUrl = "https://api.groq.com/openai/v1";

    static async Task<string> GetAIResponse(string userInput)
    {
        var requestData = new
        {
            model = "llama3-8b-8192",
            messages = new[] { new { role = "user", content = userInput } }
        };

        var jsonRequest = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        try
        {
            var response = await client.PostAsync(apiUrl, content);
            var responseString = await response.Content.ReadAsStringAsync();
            dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);
            return jsonResponse.choices[0].message.content.ToString();
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }

    static async Task Main()
    {
        Console.WriteLine("Welcome to your AI chatbot! Type 'exit' to quit.");
        while (true)
        {
            Console.Write("\nYou: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "exit" || userInput.ToLower() == "quit")
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
            string response = await GetAIResponse(userInput);
            Console.WriteLine("AI: " + response);
        }
    }
}