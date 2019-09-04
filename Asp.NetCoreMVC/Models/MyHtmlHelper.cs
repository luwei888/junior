using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc.Rendering
{
    public static class MyHtmlHelper
    {
        public static HtmlString MyLable(this IHtmlHelper helper,string lbText)
        {
            string str= string.Format("<p>{0}</p>",lbText);

            return new HtmlString(str);
        }
    }
}
