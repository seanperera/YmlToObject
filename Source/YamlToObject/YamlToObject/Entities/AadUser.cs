using YamlDotNet.Serialization;

namespace YamlToObject.Entities
{
    public class AadUser 
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email  { get; set; }
        public string Mobile { get; set; }
        public string Clinic { get; set; }
        public string DisplayName { get; set; }
    }
}