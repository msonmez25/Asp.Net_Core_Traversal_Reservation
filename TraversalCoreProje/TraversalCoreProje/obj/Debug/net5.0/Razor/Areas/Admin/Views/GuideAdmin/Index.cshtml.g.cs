#pragma checksum "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0115e5aad9b39e8b34698e03809e70cea0075375113451b417592894269b907c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GuideAdmin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/GuideAdmin/Index.cshtml")]
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
#line 1 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0115e5aad9b39e8b34698e03809e70cea0075375113451b417592894269b907c", @"/Areas/Admin/Views/GuideAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2e9bfa40ef1d83d6353d9126c17d86f4baa70909053e7ad653fe8b77069e6760", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_GuideAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""content-wrapper"">
    <div class=""card"" style=""background-color: ghostwhite"">

        <h5 class=""card-header"" style=""background-color: #566A7F;color:white"">REHBER LİSTESİ</h5>
        <br />
        <div class=""table-responsive text-nowrap"" style=""padding: 0.75rem 1.25rem;background-color: ghostwhite"">

            <table id=""tbl1"" class=""table table-bordered table-striped table-hover"" style=""text-align:center"">
                <thead>
                    <tr style=""background-color: rgba(105, 108, 255, 0.16)"">
                        <th>#</th>
                        <th>AD SOYAD</th>
                        <th>GÖRSEL</th>
                        <th>AÇIKLAMA</th>
                        <th>DETAY</th>

                        <th>DURUM</th>
                        <th>AKTİF/PASİF</th>

                    </tr>
                </thead>
");
#nullable restore
#line 32 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 35 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
                          
                            sayac = sayac + 1;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 38 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
                       Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1396, "\"", 1413, 1);
#nullable restore
#line 41 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
WriteAttributeValue("", 1402, item.Image, 1402, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"user-avatar\" class=\"rounded\" height=\"90\" width=\"100\">\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 43 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1639, "\"", 1687, 2);
            WriteAttributeValue("", 1646, "/Admin/GuideAdmin/EditGuide/", 1646, 28, true);
#nullable restore
#line 45 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
WriteAttributeValue("", 1674, item.GuideID, 1674, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                DETAY\r\n                            </a>\r\n                        </td>\r\n\r\n");
#nullable restore
#line 50 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
                         if (@item.Status == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <td>
                                <a class=""btn btn-success"" href=""#"">
                                    Rehber Aktif
                                </a>                                
                            </td>
                            <td>
                                <a class=""btn btn-danger""");
            BeginWriteAttribute("href", " href=\"", 2226, "\"", 2275, 2);
            WriteAttributeValue("", 2233, "/Admin/GuideAdmin/PasifGuide/", 2233, 29, true);
#nullable restore
#line 58 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
WriteAttributeValue("", 2262, item.GuideID, 2262, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Rehberi Pasif Yap\r\n                                </a>\r\n                            </td>\r\n");
#nullable restore
#line 62 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
                         if (@item.Status == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <td>
                                <a class=""btn btn-danger"" href=""#"">
                                    Rehber Kapalı
                                </a>
                            </td>
                            <td>
                                <a class=""btn btn-success""");
            BeginWriteAttribute("href", " href=\"", 2835, "\"", 2884, 2);
            WriteAttributeValue("", 2842, "/Admin/GuideAdmin/AktifGuide/", 2842, 29, true);
#nullable restore
#line 72 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
WriteAttributeValue("", 2871, item.GuideID, 2871, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Rehberi Aktif Yap\r\n                                </a>\r\n                            </td>\r\n");
#nullable restore
#line 76 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"

                        }



                       
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 87 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\GuideAdmin\Index.cshtml"
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

<a href=""/Admin/GuideAdmin/AddGuide"" class=""btn btn-primary"" style=""color: #fff; background-color: #696cff; border-color: #696cff;"">Yeni Rehber Ekle</a>




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
            ""url"": ""//cdn.datatables.net/plug-ins/1.10.12/");
            WriteLiteral("i18n/Turkish.json\"\r\n        }\r\n    });\r\n</script>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
