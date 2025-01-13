# MLSampleApp

**MLSampleApp** is a demo application designed to showcase the use of **ML.NET** for building and consuming machine learning models within a .NET console application. This project provides an end-to-end example, from training a model to integrating it into a console app, making it a perfect starting point for developers interested in exploring machine learning capabilities in .NET applications.

## Features

- **Model Training with ML.NET**: Demonstrates how to create and train a machine learning model using ML.NET’s intuitive API.
- **Model Consumption in a Console Application**: Shows how to load and use the trained model to make predictions within a simple console application.
- **Reusable Code Structure**: Organized code structure to help you easily extend the functionality and experiment with different ML models.

## Getting Started

### Prerequisites

- **.NET SDK** (8.0 or higher) - Download from [here](https://dotnet.microsoft.com/download).
- **ML.NET** (v2.0 or higher) - For more information on ML.NET, check the [official documentation](https://docs.microsoft.com/en-us/dotnet/machine-learning/).

### Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-username/MLSampleApp.git
   cd MLSampleApp
   ```

2. **Install ML.NET NuGet Package**
   In the project directory, run the following command to install the ML.NET NuGet package:
   ```bash
   dotnet add package Microsoft.ML
   ```

3. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

## Training the Model

To train the model, update `ModelTrainer.cs` with your desired dataset path or use the sample data provided in the project. Run the following command to execute the training process:

```bash
dotnet run --project ModelTrainer.cs
```

The trained model will be saved as `model.zip` in the project directory.

## Consuming the Model

After training the model, run the console application to load and use the model for predictions:

```bash
dotnet run
```

You’ll see sample predictions based on the input data, demonstrating how to integrate ML.NET models in a .NET application.

## Example Output

```plaintext
Prediction: [Result based on your model's predictions]
Confidence: [Confidence score]
```

## Contributing

We welcome contributions! Feel free to submit issues or pull requests to enhance MLSampleApp.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Resources

- [ML.NET Documentation](https://docs.microsoft.com/en-us/dotnet/machine-learning/)
- [ML.NET Samples](https://github.com/dotnet/machinelearning-samples)

---

With **MLSampleApp**, you’ll experience the full process of creating, training, and integrating a machine learning model in a .NET application. Happy coding!
