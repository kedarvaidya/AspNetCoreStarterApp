using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace StarterApp.Infrastructure.TagHelpers
{
	public class CopyrightTagHelper : TagHelper
	{
		public int FromYear { get; set; } = DateTimeOffset.Now.Year;

		public int ToYear { get; set; } = DateTimeOffset.Now.Year;

		public string Holder { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "span";
			output.Content.SetHtmlContent($"&copy; {FromYear}{(FromYear != ToYear ? $"-{ToYear}" : "")} {Holder}");
			output.TagMode = TagMode.StartTagAndEndTag;
		}
	}
}
