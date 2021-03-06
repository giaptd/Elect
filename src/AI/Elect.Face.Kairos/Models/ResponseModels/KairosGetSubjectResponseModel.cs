using System.Collections.Generic;
using Elect.Face.Kairos.Models.InfoModels;
using Newtonsoft.Json;

namespace Elect.Face.Kairos.Models.ResponseModels
{
    public class KairosGetSubjectResponseModel : KairosBaseResponseModel
    {
        [JsonProperty("face_ids")]
        public List<KairosFaceIdModel> FaceIds { get; set; }
    }
}