
 ## Berad.GradioClient .NET 
## 🌐 Select Language | انتخاب زبان

<details>
  <summary>🇬🇧 English</summary>
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

         
        // Pause to keep the console open
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


 ```

### *Send the request to the model as a JSON string*
```csharp

        // Send the request to the model as a JSON string
        var requestBodyString = "{\"data\":[\"write a method for sum 2 int\",[],\"You are an assistant C# programmer.\"]}";
        var resultBodyString = await client.Predict(requestBodyString, "/model_chat", Berad.GradioClient.NET.Utils.Enums.PredictBodyType.String);
        HandleResponse(resultBodyString);
 ```
</details>

<details>
  <summary>🇮🇷 فارسی</summary>

 # Berad GradioClient .NET

یک کتابخانه کلاینت .NET Core برای تعامل با Gradio API.

## 🚀 ویژگی‌ها
- API ساده و آسان برای استفاده  
- پشتیبانی از **Hugging Face Spaces** و **Gradio Endpoints**  
- امکان ارسال درخواست‌ها به‌صورت **آبجکت** و **رشته‌ای (JSON String)**  

## 🔹 درباره این کتابخانه

این کتابخانه‌ی .NET Core به شما امکان می‌دهد تا به‌راحتی با **[Gradio API](https://gradio.app/)** که در **Hugging Face Spaces** میزبانی شده، تعامل کنید.  
این ابزار، ارسال درخواست‌ها و دریافت پاسخ‌ها را بدون نیاز به ارسال مستقیم درخواست‌های HTTP، برای شما ساده می‌کند.  

به عنوان مثال، این کتابخانه برای مدل **Qwen2.5-Max-Demo** که در این لینک قرار دارد، قابل استفاده است:  
🔗 [Qwen/Qwen2.5-Max-Demo](https://huggingface.co/spaces/Qwen/Qwen2.5-Max-Demo)

### 🌍 **نحوه عملکرد**
در پشت صحنه، این کتابخانه با **Gradio API** ارتباط برقرار می‌کند و درخواست‌هایی مشابه کد `cURL` زیر ارسال می‌کند:

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
 
## 📦 نصب
نصب از طریق NuGet (به‌زودی):

```sh
dotnet add package Berad.GradioClient.NET
```

## 📌  نمونه استفاده
برای استفاده از این کتابخانه، می‌توانید آن را از **NuGet** نصب کرده یا فایل DLL را به‌صورت دستی اضافه کنید.


```csharp
using Berad.GradioClient.NET;
using System;

public class Program
{
    public static async Task Main(string[] args)
    {
        // مقداردهی اولیه کلاینت Gradio با نام مدل
        var client = new GradioClient("Qwen/Qwen2.5-Max-Demo");

        // بدنه‌ی درخواست
        var requestBody = new
        {
            data = new object[]
            {
                "write a method for sum 2 int",  // درخواست
                new object[] {},                // ورودی خالی
                "You are an assistant C# programmer." // متن کمکی برای مدل
            }
        };

        // ارسال درخواست به مدل
        var response = await client.Predict(requestBody, "/model_chat");

        // نمایش نتیجه در صورت موفقیت
        if (response.Successed)
        {
            Console.WriteLine(response.Value);
        }
    }
}
```
 
###  ارسال body از نوع رشته 
```csharp

        // Send the request to the model as a JSON string
        var requestBodyString = "{\"data\":[\"write a method for sum 2 int\",[],\"You are an assistant C# programmer.\"]}";
        var resultBodyString = await client.Predict(requestBodyString, "/model_chat", Berad.GradioClient.NET.Utils.Enums.PredictBodyType.String);
        HandleResponse(resultBodyString);
 ```
</details>
