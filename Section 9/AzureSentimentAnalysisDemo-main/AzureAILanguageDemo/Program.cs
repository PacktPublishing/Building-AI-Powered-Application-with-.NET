using Azure;
using Azure.AI.TextAnalytics;

string key = "LANGUAGE_KEY";
string endpoint = "LANGUAGE_ENDPOINT";

AzureKeyCredential azureKeyCredential = new(key);
Uri languageEnpoint = new(endpoint);

var client = new TextAnalyticsClient(languageEnpoint, azureKeyCredential);

var sentences = new List<string>
{
    "I loved the new Italian restaurant! The pasta was cooked perfectly, and the ambiance was delightful.",
    "The mobile app kept crashing every time I tried to log in. I’m extremely frustrated.",
    "We need to schedule a meeting to discuss the Q3 financial projections and finalize the budget."
};

// DocumentSentiment sentenceToAnalyse = client.AnalyzeSentiment("I loved the new Italian restaurant! The pasta was cooked perfectly, and the ambiance was delightful.");

AnalyzeSentimentResultCollection sentencesToAnalyse = client.AnalyzeSentimentBatch(sentences, 
options: new AnalyzeSentimentOptions() { IncludeOpinionMining = true });

foreach (AnalyzeSentimentResult sentence in sentencesToAnalyse)
{
    Console.WriteLine($"Sentence Sentiment: {sentence.DocumentSentiment.Sentiment}");
    Console.WriteLine($"Positive: {sentence.DocumentSentiment.ConfidenceScores.Positive}");
    Console.WriteLine($"Negative: {sentence.DocumentSentiment.ConfidenceScores.Negative}");
    Console.WriteLine($"Neutral: {sentence.DocumentSentiment.ConfidenceScores.Neutral}");

    foreach (var sentenceSentiment in sentence.DocumentSentiment.Sentences)
    {
        Console.WriteLine($"- Sentence Aspect: {sentenceSentiment.Text}");
        Console.WriteLine($"  - Sentiment: {sentenceSentiment.Sentiment}");
        Console.WriteLine($"  - Positive: {sentenceSentiment.ConfidenceScores.Positive}");
        Console.WriteLine($"  - Negative: {sentenceSentiment.ConfidenceScores.Negative}");
        Console.WriteLine($"  - Neutral: {sentenceSentiment.ConfidenceScores.Neutral}");

        foreach (var sentenceOpinion in sentenceSentiment.Opinions)
        {
            Console.WriteLine($"- Opinion Aspect: {sentenceOpinion.Target.Text}");
            Console.WriteLine($"  - Sentiment: {sentenceOpinion.Target.Sentiment}");
            Console.WriteLine($"  - Positive: {sentenceOpinion.Target.ConfidenceScores.Positive}");
            Console.WriteLine($"  - Negative: {sentenceOpinion.Target.ConfidenceScores.Negative}");
            Console.WriteLine($"  - Neutral: {sentenceOpinion.Target.ConfidenceScores.Neutral}");

            foreach (AssessmentSentiment assessment in sentenceOpinion.Assessments)
            {
                Console.WriteLine($"\t\tRelated Assessment: {assessment.Text}, Value: {assessment.Sentiment}");
                Console.WriteLine($"\t\tRelated Assessment positive score: {assessment.ConfidenceScores.Positive:0.00}");
                Console.WriteLine($"\t\tRelated Assessment negative score: {assessment.ConfidenceScores.Negative:0.00}");
            }
        }
    }

    Console.ReadKey();
}
