using System.Net;

namespace CodingAssessment.Api.Models
{
    public class AppResponse<T>
    {
        public T Payload { get; set; }
        public bool IsSucessful { get; set; }
        public HttpStatusCode ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }
}
