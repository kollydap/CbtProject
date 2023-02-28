using Newtonsoft.Json;

namespace Edsofta.Models
{
    public class UserModel
    {
        [JsonProperty("firstname")]
        private string firstname;
        public string FirstName
        {
            get { return  firstname; }
            set {  firstname = value; }
        }

        [JsonProperty("surname")]
        private string surname;
        public string SurName
        {
            get { return surname; }
            set { surname = value; }
        }

        [JsonProperty("username")]
        private string username;
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        [JsonProperty("email")]
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [JsonProperty("phoneNumber")]
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        [JsonProperty("password")]
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [JsonProperty("password2")]
        private string password2;
        public string Password2
        {
            get { return password2; }
            set { password2 = value; }
        }
    }

}
