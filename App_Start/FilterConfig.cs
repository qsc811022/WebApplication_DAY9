﻿using System.Web;
using System.Web.Mvc;

namespace WebApplication_DAY9
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
