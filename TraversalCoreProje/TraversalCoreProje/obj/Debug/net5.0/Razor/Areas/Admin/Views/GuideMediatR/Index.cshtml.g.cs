#pragma checksum "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8a77419c64c79b282b5658c44874ce1729f00d595c6cdc82ac6a1b485f168510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GuideMediatR_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/GuideMediatR/Index.cshtml")]
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
#line 4 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8a77419c64c79b282b5658c44874ce1729f00d595c6cdc82ac6a1b485f168510", @"/Areas/Admin/Views/GuideMediatR/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2e9bfa40ef1d83d6353d9126c17d86f4baa70909053e7ad653fe8b77069e6760", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_GuideMediatR_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAllGuideQueryResult>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-wrapper\">\r\n    <div class=\"card\" style=\"background-color: ghostwhite\">\r\n");
            WriteLiteral(@"
        <h5 class=""card-header"" style=""background-color: lightblue;"">CQRS MEDİATR REHBER LİSTESİ</h5>
        <br />
        <div class=""table-responsive text-nowrap"" style=""padding: 0.75rem 1.25rem;background-color: ghostwhite"">

            <table id=""tbl1"" class=""table table-bordered"" style=""text-align:center"">
                <thead>
                    <tr style=""background-color: rgba(105, 108, 255, 0.16)"">
                        <th>#</th>
                        <th>AD SOYAD</th>
                        <th>AÇIKLAMA</th>
                        <th>GÖRSEL</th>
                        <th>SİL</th>
                        <th>GÜNCELLE</th>

                    </tr>
                </thead>
");
#nullable restore
#line 29 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml"
                 foreach (var item in Model)
                {
                    sayac++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 33 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml"
                       Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 1292, "\"", 1309, 1);
#nullable restore
#line 36 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml"
WriteAttributeValue("", 1298, item.Image, 1298, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-px-40 h-auto rounded-circle\" /></td>\r\n\r\n                        <td>\r\n                            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1443, "\"", 1495, 2);
            WriteAttributeValue("", 1450, "/Admin/GuideMediatR/DeleteGuide/", 1450, 32, true);
#nullable restore
#line 39 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml"
WriteAttributeValue("", 1482, item.GuideID, 1482, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Sil\r\n                            </a>\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1685, "\"", 1734, 2);
            WriteAttributeValue("", 1692, "/Admin/GuideMediatR/GetGuide/", 1692, 29, true);
#nullable restore
#line 44 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml"
WriteAttributeValue("", 1721, item.GuideID, 1721, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Güncelle\r\n                            </a>\r\n                        </td>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 51 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideMediatR\Index.cshtml"
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

<a href=""/Admin/GuideMediatR/AddGuide/"" class=""btn btn-primary"" style=""color: #fff; background-color: #696cff; border-color: #696cff;"">Yeni Rehber Ekle</a>




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
            ""url"": ""//cdn.datatables.net/plug-ins/1.10.");
            WriteLiteral("12/i18n/Turkish.json\"\r\n        }\r\n    });\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAllGuideQueryResult>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591