namespace EternaMVC.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string About { get; set; }

        public List<TeamSocialMediaAccount> TeamSocialMediaAccounts { get; set; }
    }
}
