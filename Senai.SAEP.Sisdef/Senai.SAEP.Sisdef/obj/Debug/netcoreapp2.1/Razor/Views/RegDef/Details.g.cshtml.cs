#pragma checksum "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3def8a7bd08f9e32a92c7bf1c285b17656c6d316"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegDef_Details), @"mvc.1.0.view", @"/Views/RegDef/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegDef/Details.cshtml", typeof(AspNetCore.Views_RegDef_Details))]
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
#line 1 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\_ViewImports.cshtml"
using Senai.SAEP.Sisdef;

#line default
#line hidden
#line 2 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\_ViewImports.cshtml"
using Senai.SAEP.Sisdef.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3def8a7bd08f9e32a92c7bf1c285b17656c6d316", @"/Views/RegDef/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5cb1638f8dfad76ad68bca2022e85bf5ee1cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_RegDef_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Senai.SAEP.Sisdef.Domains.RegistroDefeito>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 129, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>RegistroDefeito</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(225, 47, false);
#line 14 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDefeito));

#line default
#line hidden
            EndContext();
            BeginContext(272, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(316, 43, false);
#line 17 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataDefeito));

#line default
#line hidden
            EndContext();
            BeginContext(359, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(403, 47, false);
#line 20 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoraInicial));

#line default
#line hidden
            EndContext();
            BeginContext(450, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(494, 43, false);
#line 23 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoraInicial));

#line default
#line hidden
            EndContext();
            BeginContext(537, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(581, 45, false);
#line 26 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoraFinal));

#line default
#line hidden
            EndContext();
            BeginContext(626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(670, 41, false);
#line 29 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoraFinal));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 47, false);
#line 32 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Equipamento));

#line default
#line hidden
            EndContext();
            BeginContext(802, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(846, 46, false);
#line 35 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayFor(model => model.Equipamento.Id));

#line default
#line hidden
            EndContext();
            BeginContext(892, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(936, 47, false);
#line 38 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoDefeito));

#line default
#line hidden
            EndContext();
            BeginContext(983, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1027, 48, false);
#line 41 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoDefeito.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1122, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d748815a2e42cda198e2647da8b393", async() => {
                BeginContext(1168, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\47511187811\Desktop\Lucas_Basilio-MVC\Senai.SAEP.Sisdef\Senai.SAEP.Sisdef\Views\RegDef\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1176, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1184, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1a0a4b8df4e49ba86ee769f22bc96c6", async() => {
                BeginContext(1206, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1222, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Senai.SAEP.Sisdef.Domains.RegistroDefeito> Html { get; private set; }
    }
}
#pragma warning restore 1591