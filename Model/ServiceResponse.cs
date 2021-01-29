namespace dotnet_rpg.Model
{
    //<T> it's the type of data than you want to send to the client for information
    public class ServiceResponse<T>
    {
        public T Data { get; set; }

        public bool Success { get; set; } = true;

        public string Message { get; set; } = null;
    }
}