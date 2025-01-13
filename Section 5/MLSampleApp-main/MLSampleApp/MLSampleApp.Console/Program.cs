using MLSampleApp_Console;
using static System.Formats.Asn1.AsnWriter;

// Prompt user for input values

// Build the input model from values
PredictiveModel.ModelInput modelInput = new()
{
    UDI = 2F,
    Product_ID = @"L47181",
    Air_temperature = 298.2F,
    Process_temperature = 308.7F,
    Rotational_speed = 1408F,
    Torque = 46.3F,
    Tool_wear = 3F,
};

Console.WriteLine("Comparing actual Machine_failure with predicted Machine_failure from sample data...\n\n");

// Passing input values into predictive model
var scoresWithLabel = PredictiveModel.PredictAllLabels(modelInput);

Console.WriteLine($"{"Class",-40}{"Score",-20}");
Console.WriteLine($"{"-----",-40}{"-----",-20}");
foreach (var score in scoresWithLabel)
{
    Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
}
Console.WriteLine($"{"-----",-40}{"-----",-20}");


var modelOutput = PredictiveModel.Predict(modelInput);
Console.WriteLine($"Single Prediction Result");
Console.WriteLine($"UDI: {modelOutput.UDI}");
Console.WriteLine($"Product_ID: {modelOutput.Product_ID}");
Console.WriteLine($"Air_temperature: {modelOutput.Air_temperature}");
Console.WriteLine($"Process_temperature: {modelOutput.Process_temperature}");
Console.WriteLine($"Rotational_speed: {modelOutput.Rotational_speed}");
Console.WriteLine($"Torque: {modelOutput.Torque}");
Console.WriteLine($"Tool_wear: {modelOutput.Tool_wear}");
Console.WriteLine($"Machine_failure: {modelOutput.Machine_failure}");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();