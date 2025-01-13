# Content Safety Demo

**Content Safety Demo** is a console application demonstrating how to use **Azure Content Safety** for text analysis and content moderation. This demo app analyzes text input, detects potentially harmful or inappropriate content, and flags it according to specified safety policies. Ideal for developers and content managers, this application showcases how Azure Content Safety can be integrated into .NET applications to enhance user safety and maintain community guidelines.

## Features

- **Text Analysis for Harmful Content**: Leverages Azure Content Safety to detect harmful or inappropriate language in text.
- **Configurable Safety Policies**: Allows configuration of safety levels and thresholds for flagging content, helping developers customize analysis to their application’s needs.
- **Easy-to-Use Console Interface**: Simple console interface where users can input text and instantly receive safety analysis results.

## Getting Started

### Prerequisites

- **.NET SDK** (6.0 or higher) - Download from [here](https://dotnet.microsoft.com/download).
- **Azure Subscription** with Content Safety enabled - For more information, check the [Azure Content Safety Documentation](https://learn.microsoft.com/en-us/azure/content-safety/).

### Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-username/ContentSafetyDemo.git
   cd ContentSafetyDemo
   ```

2. **Install Necessary NuGet Packages**
   In the project directory, install the required Azure Content Safety SDK package:
   ```bash
   dotnet add package Azure.AI.ContentSafety
   ```

3. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

## Project Structure

- **Program.cs**: Contains the main application logic for capturing user input, sending it to Azure Content Safety for analysis, and displaying the results.

## Running the Application

After setting up, run the application with:

```bash
dotnet run
```

You’ll be prompted to enter text for analysis. The application will then send the text to Azure Content Safety, evaluate it against configured safety policies, and output the results.

## Example Usage

```plaintext
Enter text to analyze for content safety:
> This is an example text.

```

The results display whether the content was flagged, the categories of harmful content detected, and the confidence level of each result.

## Contributing

Contributions are welcome! Please submit issues or pull requests to improve this demo application.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Resources

- [Azure Content Safety Documentation](https://learn.microsoft.com/en-us/azure/content-safety/)
- [Azure SDK for .NET](https://learn.microsoft.com/en-us/azure/sdk-for-net/)

---

With **Content Safety Demo**, you’ll see firsthand how Azure Content Safety can be used to analyze and moderate text content, helping to create safer and more respectful online environments.
