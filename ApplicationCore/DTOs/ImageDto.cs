﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
	public class ImageDto:BaseEntityDto
	{
		public string Url { get; set; }
		public int AdvertId { get; set; }
	}
}