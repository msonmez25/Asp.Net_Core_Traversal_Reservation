#pragma checksum "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\SubAbout\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "66fee707abf188d0c6faa3b28203ed276a41f4675f90b7598d953aa38ba17194"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SubAbout_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SubAbout/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"66fee707abf188d0c6faa3b28203ed276a41f4675f90b7598d953aa38ba17194", @"/Areas/Admin/Views/SubAbout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2e9bfa40ef1d83d6353d9126c17d86f4baa70909053e7ad653fe8b77069e6760", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_SubAbout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SubAbout>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\SubAbout\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    <div class=\"card\" style=\"background-color: ghostwhite\">\r\n");
            WriteLiteral(@"
        <h5 class=""card-header"" style=""background-color: #566A7F;color:white"">ALT AÇIKLAMA</h5>
        <br />
        <div class=""table-responsive text-nowrap"" style=""padding: 0.75rem 1.25rem;background-color: ghostwhite"">

            <table id=""tbl1"" class=""table table-bordered table-striped table-hover"" style=""text-align:center"">
                <thead>
                    <tr style=""background-color: rgba(105, 108, 255, 0.16)"">
                        <th>#</th>
                        <th>ÜST BAŞLIK</th>
                        <th>DETAY</th>

                    </tr>
                </thead>
");
#nullable restore
#line 24 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\SubAbout\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 27 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\SubAbout\Index.cshtml"
                       Write(item.SubAboutID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\SubAbout\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       \r\n                        <td>\r\n                            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1156, "\"", 1210, 2);
            WriteAttributeValue("", 1163, "/Admin/SubAbout/DetailSubAbout/", 1163, 31, true);
#nullable restore
#line 31 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\SubAbout\Index.cshtml"
WriteAttributeValue("", 1194, item.SubAboutID, 1194, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Detay\r\n                            </a>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 37 "D:\YAZILIM_EGİTİM_PROJELER\TraversalCore5\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\SubAbout\Index.cshtml"
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
            ""url"": ""//cdn.datatables.net/plug-ins/1.10.12/i18n/Turkish.json""
        }
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SubAbout>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
