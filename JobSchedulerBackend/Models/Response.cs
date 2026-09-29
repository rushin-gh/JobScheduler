namespace Models
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public Response() { }

        public Response(bool success, string message = null)
        {
            Success = success;
            Message = message;
        }

        public Response(string message) : this(true, message) { }
    }

    public class Response<T> : Response
    {
        public T Data { get; set; }

        public Response() { }

        public Response(bool success, string message = null, T data = default)
            : base(success, message)
        {
            Data = data;
        }

        public Response(T data) : base(true, null)
        {
            Data = data;
        }
    }
}