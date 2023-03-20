using ReDpett_API.Modal;

namespace ReDpett_API.Service
{
    public interface IDBService
    {
        //string Role { get; set; }
        void InserTransaction(Projects _data, string _guid);
        bool CreateUser(Register register);
        bool ValidateCredentials(Login loginfromuser);

    }
}
