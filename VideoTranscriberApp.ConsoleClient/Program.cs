using System.Resources;
using Xabe.FFmpeg;

var videoFilePath = "C:\\Users\\user\\Desktop\\YAZILIM ACADEMY\\Sam-Bankman-Fried.mp4";

string audioFilePath = Path.ChangeExtension(videoFilePath, "mp3");

CancellationTokenSource cts = new CancellationTokenSource();

var conversion = await FFmpeg.Conversions.FromSnippet.ExtractAudio(videoFilePath, audioFilePath);

await conversion.Start(cts.Token);