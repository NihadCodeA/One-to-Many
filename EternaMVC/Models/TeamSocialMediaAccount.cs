namespace EternaMVC.Models
{
    public class TeamSocialMediaAccount
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Icon { get; set; }
        public string RedirectUrl { get; set; }
        public Team Team { get; set; }
    }
}
