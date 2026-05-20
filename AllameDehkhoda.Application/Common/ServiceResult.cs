namespace AllameDehkhoda.Application.Common
{
    public class ServiceResult
    {
        public bool IsSucces { get; }
        public string Message { get; }
        public ServiceResult(bool isSucces, string message)
        {
            IsSucces = isSucces;
            Message = message;
        }


        public static ServiceResult Succes(string message) => new(true, message);
        public static ServiceResult Failure(string message) => new(false, message);

    }
}
