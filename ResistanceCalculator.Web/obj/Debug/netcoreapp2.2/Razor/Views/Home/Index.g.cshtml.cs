#pragma checksum "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c40bdc70e2065bf4dbdc8ea95a751e50907e32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\_ViewImports.cshtml"
using OhmCalculator;

#line default
#line hidden
#line 2 "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\_ViewImports.cshtml"
using OhmCalculator.Models;

#line default
#line hidden
#line 5 "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\Home\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c40bdc70e2065bf4dbdc8ea95a751e50907e32", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f2d1b0edf2a002b4a6c58e657ffcf71c7e36446", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResistanceCalculator.Web.Models.ColorModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-src", "~/lib/jquery/dist/jquery.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test", "window.jQuery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("crossorigin", new global::Microsoft.AspNetCore.Html.HtmlString("anonymous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString("sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = " Ohm Calculator";

#line default
#line hidden
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(187, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 300, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c40bdc70e2065bf4dbdc8ea95a751e50907e326153", async() => {
                BeginContext(478, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.FallbackSrc = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.FallbackTestExpression = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(489, 1244, true);
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

<script type=""text/javascript"">

    // Dom Ready 
    $(document).ready(function () {      
        $(""#divError"").hide();
        $(""#divSuccess"").hide();

        $('select').find('option:first').attr('selected', 'selected');

        $(""select option"").each(function () {
            setBackgroundColor($(this));
        });


        $(""#btnCalculateResistance"").click(function () {

            var data = JSON.stringify({
                'bandAColor': $('#drpFirstBand').val(),
                'bandBColor': $('#drpSecondBand').val(),
                'bandCColor': $('#drpThirdBand')");
            WriteLiteral(".val(),\r\n                \'bandDColor\': $(\'#drpFourthBand\').val()\r\n            });\r\n\r\n\r\n            // Post Method to calculate Resistance value\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \"");
            EndContext();
            BeginContext(1734, 54, false);
#line 46 "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\Home\Index.cshtml"
                 Write(Configuration.GetSection("ApplicationSettings")["url"]);

#line default
#line hidden
            EndContext();
            BeginContext(1788, 2838, true);
            WriteLiteral(@""",
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                data: data,
                success: function (result) {
                    //error
                    if (result.error != undefined) {
                        $(""#divSuccess"").hide();
                        $(""#divError"").show();
                        $(""#spnErrorText"").text(result.error);                     
                    }
                    else {
                        $('select').val("""");                        
                        $(""#divError"").empty().hide();                        
                        $(""#divSuccess"").show().delay(10000).fadeOut();
                        $(""#spnMinResistance"").text(result.minimumResistance);
                        $(""#spnMaxResistance"").text(result.maximumResistance);
                    }
                }
            });
        });






        function setBackgroundColor(element) {

           ");
            WriteLiteral(@" //var backgroundColor = ""black"";

            //switch (element.attr('id')) {
            //    case ""drpFirstBand"":
            //        SetFigureBandColor($(""#divBandFirst""), object);
            //        break;
            //    case ""drpSecondBand"":
            //        SetFigureBandColor($(""#divBandSecond""), object);
            //        break;
            //    case ""drpThirdBand"":
            //        SetFigureBandColor($(""#divBandThird""), object);
            //        break;
            //    case ""drpFourthBand"":
            //        SetFigureBandColor($(""#divBandFourth""), object);
            //        break;
            //    default:
            //}

            if (element.val() != '') {
                element.css('background-color', element.val());

                switch (element.val()) {
                    case ""black"":
                        color = ""white"";
                        break;
                    case ""red"":
                        color = ""whi");
            WriteLiteral(@"te"";
                        break;
                    case ""green"":
                        color = ""white"";
                        break;
                    case ""brown"":
                        color = ""white"";
                        break;
                    case ""blue"":
                        color = ""white"";
                        break;
                    case ""gray"":
                        color = ""white"";
                        break;
                    default:

                }
              //  element.css('color', backgroundColor);
            }
        }
    });



</script>

<h1>Ohm Calculator</h1>
<hr />
<h4 style=""text-align: justify;"">A convenient tool to calculate resistance in OHMS</h4>


<div class=""Container"">
    ");
            EndContext();
            BeginContext(4626, 2925, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c40bdc70e2065bf4dbdc8ea95a751e50907e3212786", async() => {
                BeginContext(4656, 1262, true);
                WriteLiteral(@"

        <div id=""divError"" class=""container"">
            <div class=""alert alert-danger alert-dismissable"">
                <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">×</a>
                <strong><span id=""spnErrorText""></span></strong>
            </div>
        </div>

        <div id=""divSuccess"" class=""container"">
            <div class=""alert alert-success alert-dismissable"">
                <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">×</a>
                <p>Minimum Resistance : <strong><span id=""spnMinResistance""></span></strong></p>
                <p>Maximum Resistance : <strong><span id=""spnMaxResistance""></span></strong></p>
            </div>
        </div>
        <div class=""resistor"">
            <div class=""left""></div>
            <div id=""divBandFirst"" class=""band""></div>
            <div id=""divBandSecond"" class=""band""></div>
            <div id=""divBandThird"" class=""band""></div>
            <div id=""divBandFourth"" class=");
                WriteLiteral("\"band\"></div>\r\n            <div class=\"right\"></div>\r\n        </div>\r\n\r\n       \r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"col-sm-2 control-label\">1st Band:</label>\r\n            <div class=\"col-sm-4\">\r\n                ");
                EndContext();
                BeginContext(5919, 184, false);
#line 163 "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\Home\Index.cshtml"
           Write(Html.DropDownListFor(m => m.Bands, new SelectList(Model.Bands, "Key", "Value"), htmlAttributes: new { @class = "form-control", id = "drpFirstBand" }, optionLabel: " - Select Color - "));

#line default
#line hidden
                EndContext();
                BeginContext(6103, 197, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"col-sm-2 control-label\">2nd Band:</label>\r\n            <div class=\"col-sm-4\">\r\n                ");
                EndContext();
                BeginContext(6301, 185, false);
#line 171 "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\Home\Index.cshtml"
           Write(Html.DropDownListFor(m => m.Bands, new SelectList(Model.Bands, "Key", "Value"), htmlAttributes: new { @class = "form-control", id = "drpSecondBand" }, optionLabel: " - Select Color - "));

#line default
#line hidden
                EndContext();
                BeginContext(6486, 197, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"col-sm-2 control-label\">Multiplier:</label>\r\n            <div class=\"col-sm-4\">\r\n                ");
                EndContext();
                BeginContext(6684, 196, false);
#line 178 "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\Home\Index.cshtml"
           Write(Html.DropDownListFor(m => m.Multipliers, new SelectList(Model.Multipliers, "Key", "Value"), htmlAttributes: new { @class = "form-control", id = "drpThirdBand" }, optionLabel: " - Select Color - "));

#line default
#line hidden
                EndContext();
                BeginContext(6880, 196, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"col-sm-2 control-label\">Tolerance:</label>\r\n            <div class=\"col-sm-4\">\r\n                ");
                EndContext();
                BeginContext(7077, 193, false);
#line 185 "C:\Projects\ResistanceCalculator\ResistanceCalculator.Web\Views\Home\Index.cshtml"
           Write(Html.DropDownListFor(m => m.Tolerance, new SelectList(Model.Tolerance, "Key", "Value"), htmlAttributes: new { @class = "form-control", id = "drpFourthBand" }, optionLabel: " - Select Color - "));

#line default
#line hidden
                EndContext();
                BeginContext(7270, 274, true);
                WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-sm-4"">
                <button type=""button"" class=""btn btn-outline-primary"" id=""btnCalculateResistance"">Calculate</button>
            </div>
        </div>      
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7551, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResistanceCalculator.Web.Models.ColorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
