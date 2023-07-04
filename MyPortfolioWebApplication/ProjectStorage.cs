using System.Collections.Generic;

namespace MyPortfolioWebApplication
{
	public class ProjectStorage
	{
		public static List<Project> Projects { get; private set; } = new List<Project>()
		{
			new Project
			{
				Name = "Test",
				Link= "https://github.com/NikClouse/Testirovka",
				Description="Тестриовка для собствение знания! на консолное приложения"
			}

		};

		public static void Add(Project project)
		{
			Projects.Add(project);
		}

		public static void RemoveByName(string name)
		{
			Projects.RemoveAll(x => x.Name == name);
		}
	}
}
