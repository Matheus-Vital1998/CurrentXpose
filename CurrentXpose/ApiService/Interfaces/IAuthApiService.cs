namespace CurrentXpose.ApiService.Interfaces
{
    public interface IAuthApiService
    {
        Task <object> Autenticar(string username, string password);
    }
}
