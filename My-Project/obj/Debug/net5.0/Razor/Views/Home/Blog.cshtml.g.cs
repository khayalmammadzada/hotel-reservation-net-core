#pragma checksum "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/Home/Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa0d9402988ad73833c77fd147edcbf27288f387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
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
#line 1 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/_ViewImports.cshtml"
using My_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/_ViewImports.cshtml"
using My_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/_ViewImports.cshtml"
using My_Project.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0d9402988ad73833c77fd147edcbf27288f387", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66dbc0fd1ba2b76bf941361740353d70d95737f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""about-side"" class=""text-center"">
    <div class=""container"">
        <h1 class=""fw-bolder"">Read Our Blog</h1>
    </div>
</section>

<section id=""blog"" class=""text-light"">
    <div class=""container"" data-aos=""zoom-out-down"" data-aos-duration=""1000"" data-aos-offset=""300""
         data-aos-easing=""ease-in-sine"">
        <div class=""top-text text-center mb-5"">
            <span class=""top"">Blog</span>
        </div>
        <h2 class=""text-center mb-5"">Recent Blog</h2>
        <div class=""swiper mySwiper"">
            <div class=""swiper-wrapper"">
");
#nullable restore
#line 18 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/Home/Blog.cshtml"
                 foreach (Blog item in Model.blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"swiper-slide mb-5 rounded-3\">\n                    <div class=\"img-wrapper\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa0d9402988ad73833c77fd147edcbf27288f3874724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 793, "~/images/blog/", 793, 14, true);
#nullable restore
#line 22 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/Home/Blog.cshtml"
AddHtmlAttributeValue("", 807, item.Image, 807, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                    <div class=\"properties mt-2\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 952, "\"", 959, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"uil uil-user me-1\"></i>Admin</a>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1030, "\"", 1037, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"uil uil-calender me-1\"></i>");
#nullable restore
#line 26 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/Home/Blog.cshtml"
                                                                   Write(item.Date.ToString("dd/MMM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1141, "\"", 1148, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"uil uil-comment-alt-heart me-1\"></i>");
#nullable restore
#line 27 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/Home/Blog.cshtml"
                                                                            Write(item.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments</a>\n                    </div>\n                    <div class=\"text mt-2 mb-4\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1330, "\"", 1337, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <h5>");
#nullable restore
#line 31 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/Home/Blog.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        </a>\n                        <p>\n                            ");
#nullable restore
#line 34 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/Home/Blog.cshtml"
                       Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1540, "\"", 1569, 2);
            WriteAttributeValue("", 1547, "/blog/details/", 1547, 14, true);
#nullable restore
#line 36 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/Home/Blog.cshtml"
WriteAttributeValue("", 1561, item.Id, 1561, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read Blog<i class=\"ms-1 uil uil-arrow-circle-right fs-5\"></i></a>\n                    </div>\n                </div>\n");
#nullable restore
#line 39 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Views/Home/Blog.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \n            </div>\n            <div class=\"swiper-pagination\"></div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591