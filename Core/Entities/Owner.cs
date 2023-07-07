namespace Core.Entities
{
    public class Owner :EntityBase
    {
        public string Fullname { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    } 
}
