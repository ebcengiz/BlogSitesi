using CengizBlog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CengizBlog.ViewComponents
{
	public class Categories : ViewComponent
	{
		private readonly DatabaseContext _database;

		public Categories(DatabaseContext database) //DI
		{
			_database = database;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View(await _database.Categories.ToListAsync());
		}
	}
}
