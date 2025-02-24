using Berad.GradioClient.NET;
using Berad.GradioClient.NET.Services;
using System;
using System.Text.Json;

public class Program
{
    public static async Task Main(string[] args)
    {
        // Instantiate GradioClient with a specific model
        var client = new GradioClient("Qwen/Qwen2.5-Max-Demo");

        // Data to be sent to the model
        var requestBodyObject = new
        {
            data = new object[]
            {
                "write a method for sum 2 int", // Request to the model
                new object[] {},                // Empty space for inputs
                "You are an assistant C# programmer." // Additional context for the model
            }
        };

        //// Send the request to the model as an object
        var resultBodyObject = await client.Predict(requestBodyObject, "/model_chat");
        HandleResponse(resultBodyObject);

        // Send the request to the model as a JSON string
        var requestBodyString = "{\"data\":[\"write a method for sum 2 int\",[],\"You are an assistant C# programmer.\"]}";
        var resultBodyString = await client.Predict(requestBodyString, "/model_chat", Berad.GradioClient.NET.Utils.Enums.PredictBodyType.String);
        HandleResponse(resultBodyString);


        Console.ReadKey();
    }

    // Helper method to handle responses
    private static void HandleResponse(dynamic result)
    {
        if (result.Successed)
        {
            Console.WriteLine(result.Value);
        }
        else
        {
            Console.WriteLine("Error: " + result.Error);
        }
    }
}
