using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Endpoints
{
    public static class HuggingFaceEndpoint
    {
        public static readonly string BASE_GET_DATA_SPACE = "https://huggingface.co/api/spaces/{0}";

 
        public static readonly string GRADIO_API = "{0}{1}/call/{2}";

        public static readonly string CONFIG = "{0}/config";
    }
}
