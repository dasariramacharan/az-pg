using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.ProjectOxford.Face.Contract;
using Microsoft.ProjectOxford.Face;

namespace RdHelloFunctions
{
    public static class ImageAnalysis
    {
        [FunctionName("ImageAnalysis")]
        public static async void Run(
            //input Bindings
            [BlobTrigger("images/{name}", Connection = "rdhellostorage")]
                                CloudBlockBlob blob, string name, TraceWriter log,
            
            //ouput Bindings
            [CosmosDB("rdhelloazure","images",ConnectionStringSetting ="rddb")]
             IAsyncCollector<FaceAnalysisResult> result)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {blob.Properties.Length} Bytes");

            var sas = GetSas(blob);
            var url = blob.Uri + sas;

            log.Info($"Blob url is {url}");

            //TODO: test running this code with test data 

            var faces = await GetAnalysisAsync(url);
            await result.AddAsync(new FaceAnalysisResult { Faces = faces, ImageId = blob.Name });
        }

        public static async Task<Face[]> GetAnalysisAsync(string url)
        {
            var client = new FaceServiceClient("83e27e8f9a4a47bda12612275fa77d66",  //TODO:Secure key
                                "https://southeastasia.api.cognitive.microsoft.com/face/v1.0");
            var types = new []{ FaceAttributeType.Emotion };
            var result = await client.DetectAsync(url, false, false, types);
            return result;

        }

        public static string GetSas(CloudBlockBlob blob)
        {
            var sasPolicy = new SharedAccessBlobPolicy
            {
                Permissions = SharedAccessBlobPermissions.Read,
                SharedAccessStartTime = DateTime.UtcNow.AddMinutes(-15),
                SharedAccessExpiryTime = DateTime.UtcNow.AddMinutes(15)
            };
            var sas = blob.GetSharedAccessSignature(sasPolicy);
            return sas;
        }
    }
}
