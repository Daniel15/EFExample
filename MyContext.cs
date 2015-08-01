using Microsoft.Framework.Configuration;
using System.Data.Entity;

namespace Daniel15.EFTest
{
	[DbConfigurationType(typeof(MyDbConfiguration))]
    public class MyContext : DbContext
    {
		public MyContext(IConfiguration config)
			: base(config.Get("Data:DefaultConnection:ConnectionString"))
		{
		}

		public virtual DbSet<Post> Posts { get; set; }
    }

	public class Post
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
	}
}
