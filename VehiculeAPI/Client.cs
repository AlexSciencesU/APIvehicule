namespace VehiculeAPI
{
    public class Client
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public string LicenseDate { get; set; }
        public string LicenseClientId { get; set; }

        public Client(string username, string password, string birthdate)
        {
            this.Username = username;
            this.Password = password;
            this.BirthDate = birthdate;
        }

    }
}