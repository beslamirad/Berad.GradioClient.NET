# Berad GradioClient .NET

A .NET Core client library for interacting with Gradio APIs.

## 🚀 Features
- Simple and easy-to-use API
- Supports Hugging Face Spaces & Gradio endpoints
- Allows both object-based and string-based requests

## 🔹 About This Library

This .NET Core library allows you to interact with [Gradio APIs](https://gradio.app/) hosted on Hugging Face Spaces.  
It simplifies sending requests and receiving responses without manually handling HTTP calls.

For example, this library can be used with the **Qwen2.5-Max-Demo** model hosted at:  
🔗 [Qwen/Qwen2.5-Max-Demo](https://huggingface.co/spaces/Qwen/Qwen2.5-Max-Demo)

### 🌍 **How it Works?**
Under the hood, this library communicates with the **Gradio API** by sending HTTP requests similar to the following `cURL` command:

```sh
curl -X POST https://qwen-qwen2-5-max-demo.hf.space/gradio_api/call/model_chat -s \
  -H "Content-Type: application/json" \
  -d '{
        "data": [
          "Hello!!",
          [["Hello!", None]],
          "Hello!!"
        ]
      }' \
  | awk -F'"' '{ print $4}' \
  | read EVENT_ID; curl -N https://qwen-qwen2-5-max-demo.hf.space/gradio_api/call/model_chat/$EVENT_ID

```
## 📦 Installation
Install via NuGet (Coming soon):

```sh
dotnet add package Berad.GradioClient.NET
```

## 📌 Usage Example

To use this library, first install it via NuGet (coming soon) or add the DLL manually.

### **Basic Example**
```csharp
using Berad.GradioClient.NET;
using System;

public class Program
{
    public static async Task Main(string[] args)
    {
        // Initialize the Gradio client with the model name
        var client = new GradioClient("Qwen/Qwen2.5-Max-Demo");

        // Define the request body
        var requestBody = new
        {
            data = new object[]
            {
                "write a method for sum 2 int",  // Request
                new object[] {},                // Empty input
                "You are an assistant C# programmer." // Model context
            }
        };

        // Send request to the model
        var response = await client.Predict(requestBody, "/model_chat");

        // Print response if successful
        if (response.Successed)
        {
            Console.WriteLine(response.Value);
        }
    }
}
