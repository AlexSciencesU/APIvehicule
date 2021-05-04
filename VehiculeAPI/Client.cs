namespace VehiculeAPI
{
    public class Client
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Client(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

    }
}