﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGroup.Utility
{
	public class JsonResponse
	{
		public string Result { get; set; } = "ok";
		public string Message { get; set; } = "Success";
		public object Data { get; set; }
		public object Error { get; set; }
	}
}