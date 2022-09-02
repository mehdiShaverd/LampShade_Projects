#pragma checksum "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be930b15574ba0129307959f5ab8894f2e4ffe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Inventory.Areas_Administration_Pages_Inventory_OperationLog), @"mvc.1.0.view", @"/Areas/Administration/Pages/Inventory/OperationLog.cshtml")]
namespace ServiceHost.Pages.Inventory
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
#line 1 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be930b15574ba0129307959f5ab8894f2e4ffe7", @"/Areas/Administration/Pages/Inventory/OperationLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49bdd27e8b016acb3c031a38b8da4d14315ca499", @"/Areas/Administration/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administration_Pages_Inventory_OperationLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InventoryManagement.Application.Contract.Inventory.InventoryOperationViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal-header"">
    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
    <h4 class=""modal-title"">سوابق گردش انبار</h4>
</div>

<div class=""modal-body"">
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>تعداد</th>
                <th>تاریخ</th>
                <th>عملیات</th>
                <th>موجودی فعلی</th>
                <th>عملگر</th>
                <th>توضیحات</th>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 726, "\"", 791, 2);
            WriteAttributeValue("", 734, "text-white", 734, 10, true);
#nullable restore
#line 25 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
WriteAttributeValue(" ", 744, item.Operation ? "bg-success" : "bg-danger", 745, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 26 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.OperationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 30 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                         if (item.Operation)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>افزایش</span>\r\n");
#nullable restore
#line 33 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>کاهش</span>\r\n");
#nullable restore
#line 37 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>");
#nullable restore
#line 39 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.CurrentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.Operator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "E:\CSharp\Code\Lampshade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">بستن</button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InventoryManagement.Application.Contract.Inventory.InventoryOperationViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591