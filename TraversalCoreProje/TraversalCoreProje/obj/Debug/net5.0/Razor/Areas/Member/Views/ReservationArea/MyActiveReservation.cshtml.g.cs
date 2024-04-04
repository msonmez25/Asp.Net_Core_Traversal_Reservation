#pragma checksum "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ec13b917294f81965c4a946d1cebdde9b7ac58f8e17fa56017e2dbc4f9ff997"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_ReservationArea_MyActiveReservation), @"mvc.1.0.view", @"/Areas/Member/Views/ReservationArea/MyActiveReservation.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3ec13b917294f81965c4a946d1cebdde9b7ac58f8e17fa56017e2dbc4f9ff997", @"/Areas/Member/Views/ReservationArea/MyActiveReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a2f149ca4a9944edb17b61a98a84eb4808e3df359f07471e1c05de7d2a7f5e76", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_ReservationArea_MyActiveReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
  
    ViewData["Title"] = "MyActiveReservation";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Basic Tables start -->

<div class=""col-12"">
    <div class=""card"">
        <div class=""card-header"" style=""padding-bottom: 0"">           
            <h3 class=""mt-1 danger"">Onaylanan Rezervasyonlarım</h3>
            <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
            <div class=""heading-elements"">
                <ul class=""list-inline mb-0"">
                    <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                    <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                    <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                    <li><a data-action=""close""><i class=""ft-x""></i></a></li>
                </ul>
            </div>
            <p class=""text-sm"">Web Sitemiz <code>Traversal</code> üzerinden yapmış olduğunuz aktif rezervasyon listesini aşağıda görebilirsiniz.</p>
        </div>
        <div class=""card-content collapse show"">
            <div ");
            WriteLiteral(@"class=""card-body"">
                
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Ülke</th>
                                <th>Şehir</th>
                                <th>Kişi Sayısı</th>
                                <th>Rezervasyon Tarihi</th>
                                <th>Durum</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 44 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
                             foreach (var item in Model)
                            {
                                sayac++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 48 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
                                               Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 49 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
                                   Write(item.Destination.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
                                   Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 51 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
                                   Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 52 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
                                    Write(((DateTime)item.ReservationDate).ToString("dd-MMMMMMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 53 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
                                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 55 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\ReservationArea\MyActiveReservation.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- Basic Tables end -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
