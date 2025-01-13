using Azure;
using Azure.AI.Vision.ImageAnalysis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureVisionCaptionDemo.Pages;

public class IndexModel : PageModel
{

    private readonly ILogger<IndexModel> _logger;

    public class ImageCaptionModel
    {
        public IFormFile Image { get; set; }
        public string ImageData { get; set; }
        public string ImageCaption { get; set; }
    }

    [BindProperty]
    public ImageCaptionModel Input { get; set; } = new();

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPostAsync()
    {
        string endpointUrl = "";
        string key = "";

        ImageAnalysisClient client = new(new Uri(endpointUrl), new AzureKeyCredential(key));

        if (Input.Image != null)
        {
            using MemoryStream ms = new();
            await Input.Image.CopyToAsync(ms);
            ms.Position = 0;
            Input.ImageData = Convert.ToBase64String(ms.ToArray());

            ImageAnalysisResult imageAnalysisResult = await client.AnalyzeAsync(BinaryData.FromStream(ms), VisualFeatures.Caption, new ImageAnalysisOptions{
                GenderNeutralCaption = true
            });

            Input.ImageCaption = $"Caption: {imageAnalysisResult.Caption.Text} | Confidence: {imageAnalysisResult.Caption.Confidence}";

        }

        return Page();
    }
}
