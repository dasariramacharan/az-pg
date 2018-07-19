using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.WindowsAzure.Storage.Blob;

namespace RdHelloFunctions
{
    public static class ImageAnalysis
    {
        [FunctionName("ImageAnalysis")]
        public static void Run([BlobTrigger("images/{name}", Connection = "rdhellostorage")]
                                CloudBlockBlob blob, string name, TraceWriter log)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {blob.Properties.Length} Bytes");

            var sas = GetSas(blob);
            var url = blob.Uri + sas;

            log.Info($"Blob url is {url}");

            //TODO: test running this code with test data 
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
