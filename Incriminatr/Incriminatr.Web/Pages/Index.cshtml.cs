﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Incriminatr.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string TestProperty { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            TestProperty = "test";
        }

        public void OnGet()
        {
        }
    }
}