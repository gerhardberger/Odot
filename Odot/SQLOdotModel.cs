using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Odot
{
	public class SQLOdotModel: IOdotModel
	{
		SQLiteAsyncConnection db;

		string DatabasePath
		{
			get
			{
				var sqliteFilename = "OdotSQLite.db3";
#if __IOS__
				string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
				string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
				var path = Path.Combine(libraryPath, sqliteFilename);
#else
#if __ANDROID__
				string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
				var path = Path.Combine(documentsPath, sqliteFilename);
#else
				// var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
				var path = sqliteFilename;
#endif
#endif
				return path;
			}
		}

		public SQLOdotModel()
		{
			db = new SQLiteAsyncConnection(DatabasePath);
			db.CreateTableAsync<OdotTask>();
		}

		public async Task<List<OdotTask>> GetTasks()
		{
			return await db.Table<OdotTask>().ToListAsync();
		}

		public async Task AddTask(OdotTask task)
		{
			await db.InsertAsync(task);
		}

		public async Task DeleteTask(OdotTask task)
		{
			await db.DeleteAsync(task);
		}
	}
}

