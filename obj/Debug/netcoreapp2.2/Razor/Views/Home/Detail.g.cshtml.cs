#pragma checksum "/home/roby/Documents/Kuliah/Semester_8/RPLBK/Projek/PapiKos/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0421cd4f180af9c040da4f8a14bbe9357d0e1f17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "/home/roby/Documents/Kuliah/Semester_8/RPLBK/Projek/PapiKos/Views/_ViewImports.cshtml"
using PapiKos;

#line default
#line hidden
#line 2 "/home/roby/Documents/Kuliah/Semester_8/RPLBK/Projek/PapiKos/Views/_ViewImports.cshtml"
using PapiKos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0421cd4f180af9c040da4f8a14bbe9357d0e1f17", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d486e4b2035a336079c3ae264e90fc99c33dd40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1218, true);
            WriteLiteral(@"<!--Main layout-->
  <main class=""mt-5 pt-4"">
    <div class=""container dark-grey-text mt-5"">

      <!--Grid row-->
      <div class=""row wow fadeIn"">

        <!--Grid column-->
        <div class=""col-md-6 mb-4"">

          <img src=""img/kamar5.jpg"" height=""1000"" width=""900"" class=""img-fluid"" alt="""">

        </div>
        <!--Grid column-->

        <!--Grid column-->
        <div class=""col-md-6 mb-4"">

          <!--Content-->
          <div class=""p-4"">
            <p class=""lead font-weight-bold"">Parsiajar Kost</p>

            <div class=""mb-3"">
              <a href=""kost-page.html"">
                <span class=""badge purple mr-1"">Hinalang</span>
              </a>
              <a href="""">
                <span class=""badge green mr-1"">Tobasa</span>
              </a>
            </div>

              <a href="""">
                <span class=""badge blue mr-1"">Available</span>
              </a>

            <p class=""lead"">
              <span>Rp 1.500.000/bulan</span>
            </p>

           ");
            WriteLiteral(" <p class=\"lead\">\n              <span>3 X 5 meter</span>\n            </p>\n\n            <p>Ayo Kos Baru buka yang ada di medan dengan fasilitas wifi dan toilet dalam yang bersih</p>\n\n            ");
            EndContext();
            BeginContext(1218, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0421cd4f180af9c040da4f8a14bbe9357d0e1f174943", async() => {
                BeginContext(1260, 157, true);
                WriteLiteral("\n              <!-- Default input -->\n              <button class=\"btn btn-primary btn-md my-0 p\" type=\"submit\">Booking\n              </button>\n\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1424, 1183, true);
            WriteLiteral(@"

          </div>
          <!--Content-->

        </div>
        <!--Grid column-->

      </div>
      <!--Grid row-->

      <hr>

      <!--Grid row-->
      <div class=""row d-flex justify-content-center wow fadeIn"">

        <!--Grid column-->
        <div class=""col-md-6 text-center"">

          <h4 class=""my-4 h4"">Informasi Tambahan</h4>

        </div>
        <!--Grid column-->

      </div>
      <!--Grid row-->

      <!--Grid row-->
      <div class=""row wow fadeIn"">

        <!--Grid column-->
        <div class=""col-lg-4 col-md-12 mb-4"">

          <img src=""img/toilet.jpg"" height=""400"" width=""400"" class=""img-fluid"" alt="""">

        </div>
        <!--Grid column-->

        <!--Grid column-->
        <div class=""col-lg-4 col-md-6 mb-4"">

          <img src=""img/teras-kamar5.jpg"" height=""400"" width=""400"" class=""img-fluid"" alt="""">

        </div>
        <!--Grid column-->

        <!--Grid column-->
        <div class=""col-lg-4 col-md-6 mb-4"">

          <img src=""img/kamar5.jpg"" height=""400"" ");
            WriteLiteral("width=\"400\" class=\"img-fluid\" alt=\"\">\n\n        </div>\n        <!--Grid column-->\n\n      </div>\n      <!--Grid row-->\n\n    </div>\n  </main>\n  <!--Main layout-->");
            EndContext();
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