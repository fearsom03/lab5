#pragma checksum "/Users/edil/Documents/Course/NET/mvc_views/TestProject/TestProject/Views/Calculator/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c48ff5cb7819ee71f7ec796df0c4221868ba59da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestProject.Views.Calculator.Views_Calculator_Result), @"mvc.1.0.view", @"/Views/Calculator/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Result.cshtml", typeof(TestProject.Views.Calculator.Views_Calculator_Result))]
namespace TestProject.Views.Calculator
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c48ff5cb7819ee71f7ec796df0c4221868ba59da", @"/Views/Calculator/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f5ea9208a5864e7b46fa2bc8e973eead6cff042", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/edil/Documents/Course/NET/mvc_views/TestProject/TestProject/Views/Calculator/Result.cshtml"
  
    ViewData["Title"] = "Sum";

#line default
#line hidden
            BeginContext(39, 25, true);
            WriteLiteral("\r\n<h1 class=\"title is-1\">");
            EndContext();
            BeginContext(65, 18, false);
#line 5 "/Users/edil/Documents/Course/NET/mvc_views/TestProject/TestProject/Views/Calculator/Result.cshtml"
                  Write(ViewData["action"]);

#line default
#line hidden
            EndContext();
            BeginContext(83, 33, true);
            WriteLiteral("</h1>\r\n<h2 class=\"subtitle is-2\">");
            EndContext();
            BeginContext(117, 23, false);
#line 6 "/Users/edil/Documents/Course/NET/mvc_views/TestProject/TestProject/Views/Calculator/Result.cshtml"
                     Write(ViewData["firstNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(140, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(142, 16, false);
#line 6 "/Users/edil/Documents/Course/NET/mvc_views/TestProject/TestProject/Views/Calculator/Result.cshtml"
                                              Write(ViewData["mark"]);

#line default
#line hidden
            EndContext();
            BeginContext(158, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(160, 24, false);
#line 6 "/Users/edil/Documents/Course/NET/mvc_views/TestProject/TestProject/Views/Calculator/Result.cshtml"
                                                                Write(ViewData["secondNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(184, 4, true);
            WriteLiteral("  = ");
            EndContext();
            BeginContext(189, 18, false);
#line 6 "/Users/edil/Documents/Course/NET/mvc_views/TestProject/TestProject/Views/Calculator/Result.cshtml"
                                                                                             Write(ViewData["result"]);

#line default
#line hidden
            EndContext();
            BeginContext(207, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
