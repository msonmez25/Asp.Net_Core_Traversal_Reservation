#pragma checksum "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "22548eecda4152c394f415a36fb55918864a8c22040ad8f4372425c2668a33c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DestinationAdmin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DestinationAdmin/Index.cshtml")]
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
#line 1 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.Announcement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"22548eecda4152c394f415a36fb55918864a8c22040ad8f4372425c2668a33c4", @"/Areas/Admin/Views/DestinationAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2e9bfa40ef1d83d6353d9126c17d86f4baa70909053e7ad653fe8b77069e6760", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_DestinationAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""card"" style=""background-color: ghostwhite"">       

        <h5 class=""card-header"" style=""background-color: #566A7F;color:white"">TUR ROTALARI</h5>
        <br />
        <div class=""table-responsive text-nowrap"" style=""padding: 0.75rem 1.25rem;background-color: ghostwhite"">

            <table id=""tbl1"" class=""table table-bordered table-striped table-hover"" style=""text-align:center"">
                <thead>
                    <tr style=""background-color: rgba(105, 108, 255, 0.16)"">
                        <th>#</th>
                        <th>ÜLKE</th>
                        <th>ŞEHİR</th>
                        <th>FİYAT</th>
                        <th>KAPASİTE</th>
                        <th>SİTEDE GÖR</th>
                        <th>DETAY</th>
                        <th>SİL</th>
                        <th>DURUM</th>                        
                        <th>AÇIK/KAPALI</th>
                        

                  ");
            WriteLiteral("  </tr>\r\n                </thead>\r\n");
#nullable restore
#line 33 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 36 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                          sayac = sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 37 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                       Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                       Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                        <td>");
#nullable restore
#line 41 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                       Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n                            <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1682, "\"", 1746, 2);
            WriteAttributeValue("", 1689, "/DetailDestination/DestinationDetails/", 1689, 38, true);
#nullable restore
#line 44 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
WriteAttributeValue("", 1727, item.DestinationID, 1727, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                Sitede Gör\r\n                            </a>\r\n                        </td>\r\n\r\n                        <td>\r\n                            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1958, "\"", 2026, 2);
            WriteAttributeValue("", 1965, "/Admin/DestinationAdmin/UpdateDestination/", 1965, 42, true);
#nullable restore
#line 50 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
WriteAttributeValue("", 2007, item.DestinationID, 2007, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Detay\r\n                            </a>\r\n                        </td>\r\n\r\n                        <td>\r\n                            <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 2217, "\"", 2278, 2);
            WriteAttributeValue("", 2224, "/Admin/DestinationAdmin/DeleteRota/", 2224, 35, true);
#nullable restore
#line 56 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
WriteAttributeValue("", 2259, item.DestinationID, 2259, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Sil\r\n                            </a>\r\n                        </td>\r\n                      \r\n\r\n");
#nullable restore
#line 62 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                         if (@item.Status == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <td>
                                <a class=""btn btn-success"" href=""#"">
                                    Tur Açık
                                </a>
                            </td>
                            <td>
                                <a class=""btn btn-danger""");
            BeginWriteAttribute("href", " href=\"", 2803, "\"", 2871, 2);
            WriteAttributeValue("", 2810, "/Admin/DestinationAdmin/DeleteDestination/", 2810, 42, true);
#nullable restore
#line 70 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
WriteAttributeValue("", 2852, item.DestinationID, 2852, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Kapalı Yap\r\n                                </a>\r\n                            </td>\r\n");
#nullable restore
#line 74 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                         if (@item.Status == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <td>
                                <a class=""btn btn-danger"" href=""#"">
                                    Tur Kapalı
                                </a>
                            </td>
                            <td>
                                <a class=""btn btn-success""");
            BeginWriteAttribute("href", " href=\"", 3419, "\"", 3487, 2);
            WriteAttributeValue("", 3426, "/Admin/DestinationAdmin/ActiveDestination/", 3426, 42, true);
#nullable restore
#line 83 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
WriteAttributeValue("", 3468, item.DestinationID, 3468, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Açık Yap\r\n                                </a>\r\n                            </td>\r\n");
#nullable restore
#line 87 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                      \r\n\r\n                    </tr>\r\n");
#nullable restore
#line 92 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationAdmin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </table>
        </div>
    </div>
</div>
<br />

<a href=""/Admin/DestinationAdmin/AddDestination"" class=""btn btn-primary"" style=""color: #fff; background-color: #696cff; border-color: #696cff;"">Yeni Tur Rotası Ekle</a>




<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.21/css/dataTables.bootstrap4.min.css"">

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.21/js/dataTables.bootstrap4.min.js""></script>



<script>
    $('#tbl1').DataTable({
        ""language"": {
            ""url"": ""//cdn.datatables.net/p");
            WriteLiteral("lug-ins/1.10.12/i18n/Turkish.json\"\r\n        }\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591