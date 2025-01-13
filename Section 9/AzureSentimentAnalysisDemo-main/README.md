# Azure Sentiment Analysis Sample Project

This **Azure Sentiment Analysis Sample Project** is a console application that demonstrates how to use **Azure Cognitive Services** to analyze and assess the sentiment of text. This project showcases how to integrate Azure’s powerful sentiment analysis capabilities into .NET applications, providing real-time insights into the emotions and opinions expressed in text data.

## Features

- **Sentiment Analysis Using Azure Cognitive Services**: Uses Azure’s Text Analytics API to evaluate and classify the sentiment of text inputs as positive, neutral, or negative.
- **Confidence Score for Sentiment**: Provides confidence scores for each sentiment category, giving insights into the degree of sentiment expressed.
- **Simple Console Interface**: Enables users to input text and view sentiment analysis results directly from a console application.

## Getting Started

### Prerequisites

- **.NET SDK** (8.0 or higher) - Download from [here](https://dotnet.microsoft.com/download).
- **Azure Subscription** with Text Analytics enabled - For more details, check the [Azure Text Analytics Documentation](https://learn.microsoft.com/en-us/azure/cognitive-services/text-analytics/).

### Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-username/AzureSentimentAnalysisSample.git
   cd AzureSentimentAnalysisSample
   ```

2. **Install the Text Analytics NuGet Package**
   In the project directory, install the Azure.AI.TextAnalytics package:
   ```bash
   dotnet add package Azure.AI.TextAnalytics
   ```

3. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

## Project Structure

- **Program.cs**: Contains the main application logic for capturing user input, sending it to Azure Text Analytics for sentiment analysis, and displaying the results.

## Running the Application

After setting up the configuration, run the application with:

```bash
dotnet run
```

You will be prompted to enter text for analysis. The application will then use Azure’s Sentiment Analysis API to evaluate the text and return sentiment results.

## Example Usage

```plaintext
Enter text to analyze for sentiment:
> I love this product, it’s fantastic!

Sentiment Analysis Result:
- Sentiment: Positive
- Confidence Scores: 
   - Positive: 0.95
   - Neutral: 0.04
   - Negative: 0.01
```

The results display the overall sentiment along with confidence scores for each category, allowing you to understand how strongly each sentiment is expressed.

## Contributing

We welcome contributions! Please feel free to submit issues or pull requests to enhance this sample project.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Resources

- [Azure Text Analytics Documentation](https://learn.microsoft.com/en-us/azure/cognitive-services/text-analytics/)
- [Azure SDK for .NET](https://learn.microsoft.com/en-us/azure/sdk-for-net/)

---

This **Azure Sentiment Analysis Sample Project** provides an excellent starting point for adding sentiment analysis to your applications, enabling you to gain insights into customer feedback, social media comments, and more.
