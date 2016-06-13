using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Odot
{
	public class SimpleOdotModel : IOdotModel
	{
		List<OdotTask> tasks;

		public SimpleOdotModel()
		{
			tasks = new List<OdotTask>();
		}

		public async Task<List<OdotTask>> GetTasks()
		{
			await Task.Delay(1);

			return tasks;
		}

		public async Task AddTask(OdotTask task)
		{
			await Task.Delay(1);

			tasks.Add(task);
		}

		public async Task DeleteTask(OdotTask task)
		{
			await Task.Delay(1);

			tasks.Remove(task);
		}
	}
}

