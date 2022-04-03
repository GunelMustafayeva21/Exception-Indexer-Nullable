namespace ClassWorkPasswordCheck.Models
{
    internal  class User
    {
        public string Username { get; set; }
        private string password;
        public string Password { get { return password; } set{ if (IsDidit(value) && IsBig(value) && IsSmall(value) ) password = value; } }
        public User(string Username, string Password)
        {
            this.Username = Username;
            if (IsDidit(Password) && IsBig(Password) && IsSmall(Password))
                {
                this.Password = Password; }
            
        }
        public bool IsDidit( string Password)
        {
            foreach (char letter in Password)
            {
                if (letter >= 48 && letter <= 57)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsBig( string Password)
        {
            foreach (char letter in Password)
            {
                if (letter >= 65 && letter <= 90)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSmall( string Password)
        {
            foreach (char letter in Password)
            {
                if (letter >= 97 && letter <= 122)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
