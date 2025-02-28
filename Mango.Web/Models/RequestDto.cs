using Mango.Web.utility;
using static Mango.Web.utility.SD;

namespace Mango.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }

        public object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
