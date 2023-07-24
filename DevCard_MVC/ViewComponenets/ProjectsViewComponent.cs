using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DevCard_MVC.ViewComponenets
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>
			{
				new Project(id:1,name:" تاکسی",description:"درخواست انلاین تاکسی برای سفرهای درونشهری",image:"project-1.jpg",client:"atria"),

                new Project(id:2,name:" زودفود",description:"درخواست انلاین غذا",image:"project-2.jpg",client:"zodfood"),

                new Project(id:3,name:"مدارس",description:"سیستم مدیریت یکپارچه مدارس",image : "project-3.jpg", client:"monop"),

                new Project(id:4,name:"فضاپیما",description:"مدیریت فضاپیماهای ناسا",image : "project-4.jpg", client:"nasa"),
            };
			return View("_Projects",projects);
		}
	}
}
