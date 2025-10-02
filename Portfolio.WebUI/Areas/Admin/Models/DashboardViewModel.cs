using MyPortfolio.WebUI.DAL.Context;
using MyPortfolio.WebUI.DAL.Entities;

namespace MyPortfolio.WebUI.Areas.Admin.Models
{
    public class DashboardViewModel
    {
       public List<Message> Messages = new();
       public List<Experience> Experiences = new();
       public List<Skill> Skills = new();

    }
}
