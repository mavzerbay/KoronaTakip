#pragma checksum "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4a31e41ea1fdb73755d44a1f092a3dd4bab4048"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "Q:\source\repos\KoronaTakipV2\Views\_ViewImports.cshtml"
using KoronaTakipV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Q:\source\repos\KoronaTakipV2\Views\_ViewImports.cshtml"
using KoronaTakipV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a31e41ea1fdb73755d44a1f092a3dd4bab4048", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bbbf5711b02b4ffafa0c11198b17084e4bffaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KoronaTakipV2.Models.Data.Results>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            WriteLiteral(@"
<section class=""section"" id=""services-2"">
    <div class=""container"">

        <div class=""row justify-content-center"">
            <div class=""col-md-8 col-lg-6 text-center"">
                <div class=""section-heading"">
                    <!-- Heading -->
                    <h2 class=""section-title mb-2 text-white"">
                        COVID-19 CORONAVIRUS PANDEMIC
                    </h2>
                </div>
            </div>
        </div> <!-- / .row -->

        <div class=""row"">
            <div class=""col-lg-4 col-sm-6 col-md-6 mb-30"">
                <div class=""web-service-block"">
                    <h3>");
#nullable restore
#line 41 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalCases));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 42 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                  Write(Model.TotalCases);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-sm-6 col-md-6 mb-30\">\r\n                <div class=\"web-service-block\">\r\n                    <h3>");
#nullable restore
#line 47 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalRecovered));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 48 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                  Write(Model.TotalRecovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-sm-6 col-md-6 mb-30\">\r\n                <div class=\"web-service-block\">\r\n                    <h3>");
#nullable restore
#line 53 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalDeaths));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 54 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                  Write(Model.TotalDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-lg-4 col-sm-6 col-md-6 mb-30\">\r\n                <div class=\"web-service-block\">\r\n                    <h3>");
#nullable restore
#line 60 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalNewCasesToday));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 61 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                  Write(Model.TotalNewCasesToday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-sm-6 col-md-6 mb-30 \">\r\n                <div class=\"web-service-block\">\r\n                    <h3>");
#nullable restore
#line 66 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalNewDeathsToday));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 67 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                  Write(Model.TotalNewDeathsToday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-sm-6 col-md-6 mb-30 \">\r\n                <div class=\"web-service-block\">\r\n                    <h3>");
#nullable restore
#line 72 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalSeriousCases));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 73 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                  Write(Model.TotalSeriousCases);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-lg-4 col-sm-6 col-md-6 mb-30 \">\r\n                <div class=\"web-service-block\">\r\n                    <h3>");
#nullable restore
#line 79 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalUnresolved));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 80 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                  Write(Model.TotalUnresolved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-sm-6 col-md-6 mb-30 \">\r\n                <div class=\"web-service-block\">\r\n                    <h3>");
#nullable restore
#line 85 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalActiveCases));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 86 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                  Write(Model.TotalActiveCases);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-sm-6 col-md-6 mb-30 \">\r\n                <div class=\"web-service-block\">\r\n                    <h3>");
#nullable restore
#line 91 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalAffectedCountries));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 92 "Q:\source\repos\KoronaTakipV2\Views\Home\Index.cshtml"
                  Write(Model.TotalAffectedCountries);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KoronaTakipV2.Models.Data.Results> Html { get; private set; }
    }
}
#pragma warning restore 1591