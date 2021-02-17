#pragma checksum "C:\Users\mkoyu\Desktop\Projects\PhoneBookApp\PhoneBookApp.UI.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b080bffc540edfe750c3e4d2a842159db0352c7c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b080bffc540edfe750c3e4d2a842159db0352c7c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c596af5fbd09dfe41f38a9a29d7baac12f13ec9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/phone-book.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n           \r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-5\" id=\"phoneImage\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b080bffc540edfe750c3e4d2a842159db0352c7c3668", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-md-7"">
            <table id=""tablo"" class=""table table-hover table-responsive"">
                <thead>
                    <tr>
                        <th>İsim</th>
                        <th>Soyisim</th>
                        <th>Firma Adı</th>
                        <th>İncele</th>
                        <th>Sil</th>
                    </tr>
                </thead>
                <tbody id=""tBody"">
                </tbody>
            </table>
        </div>
    </div>
</div>



<!-- Button trigger modal -->
<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#addPersonModal"">
    İletişim Bilgileri
</button>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addPersonModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""mo");
            WriteLiteral(@"dal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close reloadContact"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">


                <div class=""table-responsive"">
                    <table id=""tableContact"" class=""table table-hover"">
                        <thead>
                            <tr>
                                <th>Adı</th>
                                <th>Telefon Numarası</th>
                                <th>Mail</th>
                                <th>Adres</th>
                                <th>Sil</th>
                            </tr>
                        </thead>
                        <tbody id=""tBody"">
                        </tbody>
                    </table>
                </div>
                <div id=""personIdHide"" style=""visibility:hidden;""></div>
     ");
            WriteLiteral(@"           <h3 class=""mt-5"">İletişim Bilgisi ekle</h3>
                <hr />
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""phoneNum"" placeholder=""Telefon numarasını giriniz.."" name=""email"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""mail"" placeholder=""Mail adresini giriniz.."" name=""pwd"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""addresss"" placeholder=""Adresi giriniz.."" name=""pwd"">
                        </div>
                        <button class=""btn btn-default"" onclick=""AddContact()"">Kaydet</button>
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
             ");
            WriteLiteral(@"   <button type=""button"" class=""btn btn-secondary reloadContact"" data-dismiss=""modal"">Kapat</button>
            </div>
        </div>
    </div>
</div>




<!-- Modal -->
<div class=""modal fade"" id=""addPersonModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addPersonModalLaber"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Kişi Kaydet</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""container"">
                    <div class=""row"">

                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" id=""addN");
            WriteLiteral(@"ame"" placeholder=""Adını Giriniz.."">
                            </div>
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" id=""addSurname"" placeholder=""Soyadını Giriniz.."">
                            </div>
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" id=""addCompanyname"" placeholder=""Firma Adını Giriniz.."">
                            </div>
                            <button class=""btn btn-default"" onclick=""AddPerson()"">Kaydet</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
            </div>
        </div>
    </div>
</div>



");
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