using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Linq;

namespace RdHelloFunctions
{
    public class ImageAnalysisStore
    {
        private DocumentClient client;
        private Uri imageAnalysisLink;

        public ImageAnalysisStore()
        {
            var uri = new Uri("https://rddb.documents.azure.com:443/"); //cosmosdb url
            var key = "q0oSPJuwDK1k2bN62ItVQobwCH3Mki2Xdp2BY5p7ayKhBgnRlfDhHoGgU3qgESVjT91TGN6Hgoz0kT1BaCGe8w=="; // access key
            client = new DocumentClient(uri, key);
            imageAnalysisLink = UriFactory.CreateDocumentCollectionUri("pshelloazure", "images");
        }

        public dynamic GetImageAnalysis(string imageId)
        {
            var spec = new SqlQuerySpec();
            spec.QueryText = "SELECT * from c where (c.ImageId = @imageid)";
            spec.Parameters.Add(new SqlParameter("@imageid", imageId));
            var result = client.CreateDocumentQuery(imageAnalysisLink, spec).ToList();
            return result;
        }
    }
}
