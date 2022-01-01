namespace Passman.Models
{
    internal class StandardCredential : ICredential
    {
        public CredentialType Type { get; } = CredentialType.Standard;
        public int Id { get; set; } = 0;
        public string Website { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public override string ToString()
        {
            return Username;
        }
    }
}
