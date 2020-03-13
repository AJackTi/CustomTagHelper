using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelper.TagHelpers
{
    [HtmlTargetElement("hello", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class HelloTag : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            output.Content.SetHtmlContent("<h3>Hello</h3>");
        }
    }
}
