using Microsoft.ProjectOxford.Face.Contract;

namespace RdHelloFunctions
{
    public class FaceAnalysisResult
    {
        public string ImageId { get; set; }
        public Face[] Faces { get; set; }
    }
}

