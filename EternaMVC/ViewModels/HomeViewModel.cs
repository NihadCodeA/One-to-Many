using EternaMVC.Models;

namespace EternaMVC.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public List<Client> Clients { get; set; }
    }
}
