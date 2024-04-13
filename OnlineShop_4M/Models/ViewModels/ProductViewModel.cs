﻿using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineShop_4M.Models.ViewModels
{
	public class ProductViewModel
	{
		public Product Product { get; set; }

        public IEnumerable<SelectListItem> CategoryDropDown { get; set; }
    }
}