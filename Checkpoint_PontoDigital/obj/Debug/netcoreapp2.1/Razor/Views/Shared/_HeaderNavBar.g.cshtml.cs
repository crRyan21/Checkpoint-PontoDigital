#pragma checksum "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c37f3ccc0d1f69935253f283d012ab9c2dd7a1c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderNavBar), @"mvc.1.0.view", @"/Views/Shared/_HeaderNavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeaderNavBar.cshtml", typeof(AspNetCore.Views_Shared__HeaderNavBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37f3ccc0d1f69935253f283d012ab9c2dd7a1c4", @"/Views/Shared/_HeaderNavBar.cshtml")]
    public class Views_Shared__HeaderNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Prancheta 1@4x.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("91px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("94px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo do Ponto Digital"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3, true);
            WriteLiteral("   ");
            EndContext();
#line 1 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
     
       var usuario = (string)ViewData["User"];
   

#line default
#line hidden
            BeginContext(61, 514, true);
            WriteLiteral(@"       
         <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"" style=""background-color: #fff;"">         
               
  <!-- <a class=""navbar-brand"" href=""#"">Navbar</a> -->
  <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Alterna navegação"">
    <span class=""navbar-toggler-icon""></span>
  </button>
  <div class=""nav-item"">
      <div class=""logotipo"">

          <a class=""nav-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 575, "\'", 609, 1);
#line 14 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 582, Url.Action("Index","Home"), 582, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(610, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(611, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27ef7f55da3a483ca143db3bf1fe6597", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(721, 189, true);
            WriteLiteral("</a>\r\n                  </div>\r\n      </div>\r\n  <div class=\"collapse navbar-collapse\" id=\"navbarNav\">\r\n    <ul class=\"navbar-nav\">\r\n      <li class=\"nav-item \">\r\n        <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 910, "\'", 944, 1);
#line 21 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 917, Url.Action("Index","Home"), 917, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(945, 125, true);
            WriteLiteral("> Home <span class=\"sr-only\">(Página atual)</span></a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1070, "\'", 1120, 2);
#line 24 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 1077, Url.Action("Index","Home"), 1077, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1104, "#funcionalidades", 1104, 16, true);
            EndWriteAttribute();
            BeginContext(1121, 91, true);
            WriteLiteral(">Funcionalidades</a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1212, "\'", 1254, 2);
#line 27 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 1219, Url.Action("Index", "Home"), 1219, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1247, "#planos", 1247, 7, true);
            EndWriteAttribute();
            BeginContext(1255, 82, true);
            WriteLiteral(">Planos</a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1337, "\'", 1383, 2);
#line 30 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 1344, Url.Action("Index", "Home"), 1344, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1372, "#quem_somos", 1372, 11, true);
            EndWriteAttribute();
            BeginContext(1384, 90, true);
            WriteLiteral(">Quem Somos</a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", "  href=\'", 1474, "\'", 1512, 1);
#line 33 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 1482, Url.Action("Login","Cliente"), 1482, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1513, 142, true);
            WriteLiteral(">Login/Cadastro</a>\r\n          </li>\r\n    </ul>\r\n  </div>\r\n</nav>\r\n   <!-- <nav class=\'menu\'>\r\n            <ul>\r\n                <li><a href=\'");
            EndContext();
            BeginContext(1656, 26, false);
#line 40 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
                        Write(Url.Action("Index","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1682, 46, true);
            WriteLiteral("\'>Home</a></li>\r\n                <li><a href=\'");
            EndContext();
            BeginContext(1729, 27, false);
#line 41 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
                        Write(Url.Action("Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 73, true);
            WriteLiteral("#funcionalidades\'>Funcionalidades</a></li>\r\n                <li><a href=\'");
            EndContext();
            BeginContext(1830, 27, false);
#line 42 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
                        Write(Url.Action("Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 71, true);
            WriteLiteral("#planos\'>Planos</a></li>                \r\n                <li><a href=\'");
            EndContext();
            BeginContext(1929, 27, false);
#line 43 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
                        Write(Url.Action("Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 38, true);
            WriteLiteral("#quem_somos\'>Quem Somos</a></li>    \r\n");
            EndContext();
#line 44 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
                 if (string.IsNullOrEmpty(usuario))
                {

#line default
#line hidden
            BeginContext(2066, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2088, "\'", 2125, 1);
#line 46 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 2095, Url.Action("Login","Cliente"), 2095, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2126, 47, true);
            WriteLiteral(" >Login/Cadastro</a></li>                    \r\n");
            EndContext();
#line 47 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
                }else
                {

#line default
#line hidden
            BeginContext(2215, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2237, "\'", 2274, 1);
#line 49 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 2244, Url.Action("Login","Cliente"), 2244, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2275, 59, true);
            WriteLiteral(" >Logout</a></li>                                        \r\n");
            EndContext();
#line 50 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Shared\_HeaderNavBar.cshtml"
                }

#line default
#line hidden
            BeginContext(2353, 69, true);
            WriteLiteral("                              \r\n            </ul>\r\n        </nav> -->");
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
