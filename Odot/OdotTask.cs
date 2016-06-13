using System;
using SQLite;

namespace Odot
{
	[Table("Items")]
	public class OdotTask
	{
		[PrimaryKey, AutoIncrement, Column("_id")]
		public int Id { get; set; }

		public OdotTask()
		{
			CreationDate = DateTime.Now;
		}

		public string Text { get; set; }

		public DateTime CreationDate { get; set; }

		public string SpannedTime
		{
			get
			{
				var span = DateTime.Now - CreationDate;
				return span.ToReadableString();
			}
		}
	}
}

