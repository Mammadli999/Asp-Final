#pragma checksum "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\Home\Resume.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1318f221c16cfdd6d13057369916ed27689ba3b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resume), @"mvc.1.0.view", @"/Views/Home/Resume.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.AppCode.Infracture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1318f221c16cfdd6d13057369916ed27689ba3b3", @"/Views/Home/Resume.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a236855dc37ee97ad21d0976099ac55c474beb5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Resume : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\Home\Resume.cshtml"
  
    ViewData["Title"] = "Resume";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"inside-sec\">\r\n    <!-- BIO AND SKILLS -->\r\n    <h5 class=\"tittle\">Bio & Skills</h5>\r\n    <div class=\"bio-info padding-30\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\Home\Resume.cshtml"
   Write(await Component.InvokeAsync("ResumeBio"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"skills\">\r\n            <!-- HARD SKILLS -->\r\n            <h5 class=\"margin-top-30\">Hard Skills</h5>\r\n            ");
#nullable restore
#line 13 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\Home\Resume.cshtml"
       Write(await Component.InvokeAsync("ResumeSkill"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"inside-sec margin-top-30\">\r\n    <!-- Professional Experience -->\r\n    <h5 class=\"tittle\">Professional Experience</h5>\r\n    <div class=\"padding-30 exp-history\">\r\n        ");
#nullable restore
#line 22 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\Home\Resume.cshtml"
   Write(await Component.InvokeAsync("ResumeExperience"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"inside-sec margin-top-30\">\r\n    <!-- Academic Background -->\r\n    <h5 class=\"tittle\">Academic Background</h5>\r\n    <div class=\"padding-30 exp-history\">\r\n        ");
#nullable restore
#line 30 "C:\Users\Abbas\Desktop\WebCv Solution\Cv.WebUI\Views\Home\Resume.cshtml"
   Write(await Component.InvokeAsync("ResumeDiploma"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
