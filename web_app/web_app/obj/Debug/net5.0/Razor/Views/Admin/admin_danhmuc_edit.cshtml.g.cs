#pragma checksum "C:\Users\Admin\Desktop\manager_library_framework\web_app\web_app\Views\Admin\admin_danhmuc_edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f76b08ec3e673cc6364950447ce93fa8ed4de380"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_admin_danhmuc_edit), @"mvc.1.0.view", @"/Views/Admin/admin_danhmuc_edit.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\manager_library_framework\web_app\web_app\Views\_ViewImports.cshtml"
using web_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\manager_library_framework\web_app\web_app\Views\_ViewImports.cshtml"
using web_app.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f76b08ec3e673cc6364950447ce93fa8ed4de380", @"/Views/Admin/admin_danhmuc_edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09f75670bebba65d77ad3f3ecf0d6f7d2eb19d5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_admin_danhmuc_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_update_category"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\" dir=\"ltr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f76b08ec3e673cc6364950447ce93fa8ed4de3804293", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <link rel=""stylesheet"" href=""../../css/Admin_css/admin_danhmuc_edit.css"">
    <link href='https://unpkg.com/boxicons@2.0.7/css/boxicons.min.css' rel='stylesheet'>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
    <script type=""text/javascript"" src=""../../javascript/process.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f76b08ec3e673cc6364950447ce93fa8ed4de3806034", async() => {
                WriteLiteral(@"
    <div class=""sidebar"">
        <div class=""logo-details"">
            <i class='bx bx-book-reader'></i>
            <span class=""logo_name"">VKBook</span>
        </div>
        <ul class=""nav-links"">
            <li id=""Thongke_menu"">
                <a href=""./admin.html"">
                    <i class='bx bx-grid-alt'></i>
                    <span class=""link_name"">Thống kê</span>
                </a>
            </li>
            <li id=""danhmuc_menu"">
                <div class=""icon-link"">
                    <a href=""./admin_danhmuc.html"">
                        <i class='bx bx-collection'></i>
                        <span class=""link_name"">Danh mục</span>
                    </a>
                </div>
            </li>
            <li>
                <div class=""icon-link"">
                    <a href=""./admin_sanpham.html"">
                        <i class='bx bx-package'></i>
                        <span class=""link_name"">Sản phẩm</span>
                    </a>
  ");
                WriteLiteral(@"              </div>
            </li>
            <li>
                <div class=""icon-link"">
                    <a href=""./admin_donhang.html"">
                        <i class='bx bx-receipt'></i>
                        <span class=""link_name"">Đơn hàng</span>
                    </a>
                </div>
            </li>
            <li>
                <a href=""./admin_user.html"">
                    <i class='bx bx-user'></i>
                    <span class=""link_name"">Người dùng</span>
                </a>
            </li>
            <li>
                <a href=""#"">
                    <i class='bx bx-user-plus'></i>
                    <span class=""link_name"">Quyền</span>
                </a>
            </li>

            <div class=""profile-details"">
                <div class=""profile-content"">
                    <img src=""../../css/img/admin.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 2746, "\"", 2752, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""name-job"">
                    <div class=""profile_name"">Messi</div>
                    <div class=""job"">Admin</div>
                </div>
                <div class=""logout-button""><i class='bx bx-log-out'></i></div>
            </div>
            </li>
        </ul>
    </div>
    <section class=""home-section"">
        <!-- Top Nav -->
        <div class=""home-content"">
            <a class=""text"" href=""./admin.html"">VKBook Admin</a>
        </div>
        <!-- End Top Nav -->
        <div class=""content"">
            <div class=""danhmuc_edit"">

                <div class=""card_header"">
                    <h4 class=""card_title text-center"">Sửa danh mục</h4>
                </div>
                <div class=""card_body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f76b08ec3e673cc6364950447ce93fa8ed4de3809309", async() => {
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <label>Tên danh mục:</label>
                            <input type=""text"" name=""name"" class=""form-control"" placeholder=""Tên danh mục...."" id=""category_name"">
                        </div>
                        <div class=""form-group"">
                            <label>Mô tả danh mục:</label>
                            <textarea class=""form-control"" name=""describe"" cols=""30"" rows=""10"" placeholder=""Mô tả danh mục...."" id=""category_des""></textarea>
                        </div>
                        <div class=""form-group"" style=""display: grid;"">
                            <input type=""button"" value=""Sửa"" class=""btn btn-primary"" onclick=""updateCategory()"">
                        </div>
                        <div class=""form-group"">
                            <a href=""./admin_danhmuc.html"" class=""form-control btn btn-warning text-white"">Cancel</a>
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
