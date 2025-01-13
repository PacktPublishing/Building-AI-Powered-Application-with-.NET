# Azure AI Vision Image Captioning Web Application

This **Image Captioning Web Application** uses **Azure AI Vision** to analyze uploaded images and generate descriptive captions. Users can upload an image through the web interface, and Azure AI Vision’s advanced image processing capabilities will generate an appropriate caption based on the content of the image. This application demonstrates how to integrate Azure’s image analysis features into a modern web application to enhance user engagement and accessibility.

## Features

- **Image Upload**: Users can upload images in various formats (JPEG, PNG, etc.).
- **Image Captioning with Azure AI Vision**: Automatically generates a descriptive caption for each uploaded image using Azure’s image analysis service.
- **Real-Time Caption Display**: Displays the generated caption to users in real time, enhancing user experience and accessibility.

## Getting Started

### Prerequisites

- **Azure Subscription** with Azure AI Vision service enabled - For more details, check the [Azure AI Vision Documentation](https://learn.microsoft.com/en-us/azure/cognitive-services/computer-vision/).
- **Azure Vision API Key and Endpoint** - Retrieve these from your Azure portal after enabling the service.
- **.NET SDK** (6.0 or higher) - if the backend is implemented in .NET.

### Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-username/AzureAIVisionImageCaptioningApp.git
   cd AzureAIVisionImageCaptioningApp
   ```

2. **Install Dependencies**
   - Install necessary packages for the backend and frontend by navigating to the project’s backend and frontend directories and running:
     ```bash
     dotnet restore   # For .NET backend
     ```

5. **Access the Web Application**
   - `dotnet run` 

## Using the Application

1. Go to the application’s main page.
2. Upload an image by clicking the “Upload” button and selecting a file.
3. The application sends the image to Azure AI Vision for analysis.
4. Once analyzed, the generated caption is displayed below the image.

## Example Workflow

1. **User Uploads Image**: The user uploads an image of a sunset over the ocean.
2. **Azure AI Vision Generates Caption**: The backend sends the image to Azure, which analyzes it and returns a caption like “A beautiful sunset over the ocean with colorful skies.”
3. **Caption Displayed**: The caption appears on the webpage below the image, providing the user with meaningful feedback.

## Customization

- **Adjust Image Formats**: Modify allowed image formats in the frontend to control which file types can be uploaded.
- **Enhance Styling**: Customize the web interface’s CSS to match your branding and provide a more personalized user experience.

## Contributing

We welcome contributions! Feel free to submit issues or pull requests to improve this application.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Resources

- [Azure AI Vision Documentation](https://learn.microsoft.com/en-us/azure/cognitive-services/computer-vision/)
- [Azure SDK for .NET](https://learn.microsoft.com/en-us/azure/sdk-for-net/)

---

This **Image Captioning Web Application** serves as a great foundation for adding image analysis capabilities to web applications, enhancing user engagement and accessibility through the power of Azure AI Vision.
