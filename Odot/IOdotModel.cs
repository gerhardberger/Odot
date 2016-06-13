using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Odot
{
	public interface IOdotModel
	{
		Task<List<OdotTask>> GetTasks();

		Task AddTask(OdotTask task);

		Task DeleteTask(OdotTask task);
	}
}

