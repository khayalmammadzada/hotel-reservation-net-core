#pragma checksum "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Areas/Admin/Views/Booking/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb6dfe98af55ff0eaae4d1c2926261d31d7601ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Booking_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Booking/Delete.cshtml")]
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
#line 1 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Areas/Admin/Views/_ViewImports.cshtml"
using My_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6dfe98af55ff0eaae4d1c2926261d31d7601ca", @"/Areas/Admin/Views/Booking/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043bf933d853672978d7990b8a4899363b5f5c6c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Booking_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<My_Project.Models.BookingModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 class=\"text-danger\">Do you really want to delete this message?</h2>\n<p>Name: ");
#nullable restore
#line 3 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Areas/Admin/Views/Booking/Delete.cshtml"
    Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Address: ");
#nullable restore
#line 4 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Areas/Admin/Views/Booking/Delete.cshtml"
       Write(Model.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Phone: ");
#nullable restore
#line 5 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Areas/Admin/Views/Booking/Delete.cshtml"
     Write(Model.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Check In: ");
#nullable restore
#line 6 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Areas/Admin/Views/Booking/Delete.cshtml"
        Write(Model.BookingTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Check Out: ");
#nullable restore
#line 7 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Areas/Admin/Views/Booking/Delete.cshtml"
         Write(Model.BookingFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Number Of Members: ");
#nullable restore
#line 8 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Areas/Admin/Views/Booking/Delete.cshtml"
                 Write(Model.NumberOfMembers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<a");
            BeginWriteAttribute("href", " href=\"", 340, "\"", 387, 2);
            WriteAttributeValue("", 347, "/admin/booking/deleteconfirmed/", 347, 31, true);
#nullable restore
#line 10 "/Users/khayalmammadzada/Desktop/FullStack-Project_Reservation-System/My-Project/Areas/Admin/Views/Booking/Delete.cshtml"
WriteAttributeValue("", 378, Model.Id, 378, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<My_Project.Models.BookingModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
