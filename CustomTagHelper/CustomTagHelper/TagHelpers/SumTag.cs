using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelper.TagHelpers
{
    [HtmlTargetElement("sum", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class SumTag : TagHelper
    {
        [HtmlAttributeName("a")]
        public double a { get; set; }

        [HtmlAttributeName("b")]
        public double b { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            output.Content.SetHtmlContent((a + b).ToString());
        }
    }
}
