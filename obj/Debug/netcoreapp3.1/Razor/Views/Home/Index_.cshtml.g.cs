#pragma checksum "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8778d6d35be84777a519a09bb44eb1d669bdd961"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index_), @"mvc.1.0.view", @"/Views/Home/Index_.cshtml")]
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
#line 1 "G:\work\dotnet\openwheels\Views\_ViewImports.cshtml"
using openwheels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\work\dotnet\openwheels\Views\_ViewImports.cshtml"
using openwheels.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\work\dotnet\openwheels\Views\_ViewImports.cshtml"
using openwheels.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8778d6d35be84777a519a09bb44eb1d669bdd961", @"/Views/Home/Index_.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419faa760c6c307eccb65dec4c048e073b2e08a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index_ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("setFocus()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::openwheels.Models.TagHelpers.PageLinkTagHelper __openwheels_Models_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
   
    Layout = "/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\" src=\"/js/FeedEk.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8778d6d35be84777a519a09bb44eb1d669bdd9615544", async() => {
                WriteLiteral("\r\n    <title>Ф1 говорильня</title>\r\n    <meta name=\"description\" content=\"Новости, общение, флуд о Формуле-1\">\r\n");
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
            WriteLiteral(@"
<style>
    
    .exmp3 img{
        height: auto;
        width: auto;
        object-fit: cover;
        
    }
    
    .con {
        margin-right: 20px;
        display: inline-block;
    }
    
    .pageLinks {
        display: flex;
        flex-direction: row;
        justify-content: flex-start;
    }
    
    .readMore {
        cursor: pointer;
        opacity: .5;
        font-weight: 700;
        text-align: right;
    }
    
    .readMore:hover {
        transition: ease-in .2s;
        opacity: 1;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8778d6d35be84777a519a09bb44eb1d669bdd9617194", async() => {
                WriteLiteral("\r\n    <div  id=\"main\"></div>\r\n    <div class=\"container\" style=\"margin-bottom: 20px;\">\r\n        <div class=\"row\">\r\n\r\n            <div class=\"leftcolumn\">\r\n\r\n");
#nullable restore
#line 51 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                 if(Model.Posts.Count() != 0) 
                { 
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                     foreach (var news in Model.Posts) 
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"card\">\r\n                            <h2");
                BeginWriteAttribute("onclick", " onclick=\"", 1270, "\"", 1320, 3);
                WriteAttributeValue("", 1280, "location.href=\'/Home/PostView/", 1280, 30, true);
#nullable restore
#line 56 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
WriteAttributeValue("", 1310, news.Id, 1310, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1318, "\';", 1318, 2, true);
                EndWriteAttribute();
                WriteLiteral(" \r\n                                style=\"cursor: pointer;\" class=\"link link--kukuri\" data-letters=\"");
#nullable restore
#line 57 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                                                                            Write(news.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                \r\n                                 ");
#nullable restore
#line 59 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                            Write(news.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                            </h2>\r\n                            <div style=\"display: inline;\">\r\n                                <h5 style=\"width: 80%\"><em>");
#nullable restore
#line 62 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                                      Write(news.Subtitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</em> </h5>\r\n                                <span style=\"float: right; font-size: smaller;\">\r\n                                        <span>");
#nullable restore
#line 64 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                         Write(news.Posted.ToShortTimeString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" , </span> ");
#nullable restore
#line 64 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                                                                    Write(news.Posted.Date.ToString("d/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" г.</span>\r\n                            </div>\r\n                            <hr>\r\n                            <div class=\"exmp3\" style=\"height: 100%;\" >\r\n");
#nullable restore
#line 68 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                 if(news.VideoLink == null) 
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <img");
                BeginWriteAttribute("src", " src=\"", 2199, "\"", 2220, 1);
#nullable restore
#line 70 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
WriteAttributeValue("", 2205, news.ImageFile, 2205, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 71 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                }else 
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <iframe class=\"embeddedVideo\" style=\"margin: auto; display: none; height: 100%\"");
                BeginWriteAttribute("src", " src=\"", 2410, "\"", 2431, 1);
#nullable restore
#line 73 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
WriteAttributeValue("", 2416, news.VideoLink, 2416, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" \r\n                                    frameborder=\"0\" allowfullscreen></iframe> \r\n");
#nullable restore
#line 75 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n");
#nullable restore
#line 77 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                               
                                if(news.Text != null) 
                                    { 
                                        int i = 0; 
                                        foreach (var str in news.Text.Split('\n')) 
                                            { if(i == 6) break;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <p>");
#nullable restore
#line 83 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                              Write(str);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 84 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                                i++; 
                                            } 
                                        if(news.Text.Split('\n').Count() > 3) 
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <h5");
                BeginWriteAttribute("onclick", " onclick=\"", 3260, "\"", 3310, 3);
                WriteAttributeValue("", 3270, "location.href=\'/Home/PostView/", 3270, 30, true);
#nullable restore
#line 88 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
WriteAttributeValue("", 3300, news.Id, 3300, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3308, "\';", 3308, 2, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"readMore\">читать дальше...</h5>\r\n");
#nullable restore
#line 89 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"


                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""commentsCounter"">
                                            
                                        </div>
                                        <div class=""readMore"" style=""display: inline-block; opacity: .5"">
                                            <i class=""fa fa-eye"" title=""Раз просмотрено""></i> ");
#nullable restore
#line 96 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                                                                         Write(news.Rating);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 98 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                    } 
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8778d6d35be84777a519a09bb44eb1d669bdd96115334", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 102 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => news.Rating);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 104 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                      
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    \r\n                     \r\n                        <div class=\"con\">\r\n");
#nullable restore
#line 109 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                             if (Model.PageViewModel.HasPreviousPage) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8778d6d35be84777a519a09bb44eb1d669bdd96117771", async() => {
                    WriteLiteral("\r\n                                <i class=\"glyphicon glyphicon-chevron-left\"></i> Назад\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                                       WriteLiteral(Model.PageViewModel.PageNumber - 1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 113 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div  class=\"con\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8778d6d35be84777a519a09bb44eb1d669bdd96120554", async() => {
                }
                );
                __openwheels_Models_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::openwheels.Models.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__openwheels_Models_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 116 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
__openwheels_Models_TagHelpers_PageLinkTagHelper.PageModel = Model.PageViewModel;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __openwheels_Models_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __openwheels_Models_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"con\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8778d6d35be84777a519a09bb44eb1d669bdd96122266", async() => {
                }
                );
                __openwheels_Models_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::openwheels.Models.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__openwheels_Models_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 119 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
__openwheels_Models_TagHelpers_PageLinkTagHelper.PageModel = Model.PageViewModel;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __openwheels_Models_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __openwheels_Models_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"con\">\r\n");
#nullable restore
#line 122 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                             if (Model.PageViewModel.HasNextPage) 
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8778d6d35be84777a519a09bb44eb1d669bdd96124251", async() => {
                    WriteLiteral("\r\n                                    Вперед\r\n                                    <i class=\"glyphicon glyphicon-chevron-right\"></i>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                                                       WriteLiteral(Model.PageViewModel.PageNumber + 1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n");
#nullable restore
#line 128 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                     \r\n");
#nullable restore
#line 131 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                         if(User.Identity.IsAuthenticated) {

                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div >\r\n                            ");
#nullable restore
#line 135 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                       Write(Html.ActionLink("AddLongread", "AddLongread", null, null, new { @class="addPost btn btn-primary", style=" margin-right: 10px; float: right"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 137 "G:\work\dotnet\openwheels\Views\Home\Index_.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div id=""modDialog"" class=""modal fade"">
                        <div id=""dialogContent"" style="" max-width: 1000px"" class=""modal-dialog""></div>
                    </div>
                </div>
            </div>
             <div class=""rightcolumn"">
                <div class=""card"" >
                    <h2>Новости мира Открытых Колёс</h2>
                    
                    <div id=""divRss""></div>
                </div>
                <div class=""card"" style=""padding: 5px;"">
                    <h3 style=""text-align: center;"">Интересное</h3>
                     
                    <div id=""popularPartial"">

                    </div>

                </div>
                <div class=""card"" style=""padding: 5px;"">
                    <h3 style=""text-align: center;"">Новые комментарии</h3>
                     
                    <div id=""newCommentsPartial"">

                    </div>

                </div>
");
                WriteLiteral(@"            </div>

        </div>
      
        <div class=""overlay"" style=""display: none;""  ></div>
        <div id=""modalWindow"" style=""display: none;"" class=""modal-window"">
            <div style=""width: 15px; height: 15px"" class=""modal-window-close"" onclick=""$('.overlay').css('display', 'none');this.parentNode.style.display='none';"">
                <img width=""20"" height=""20"" src=""/img/close.png"">
            </div>
            <div class=""modal-window-title"">
                <a id=""linkToF1"" href=""#"" target=""_blank"">
                    Ссылка на F1 News
                </a>    
            </div>
            <div class=""modal-window-content"">
                <iframe  id=""iframe-window"" src=""about:blank"" frameborder=""0""></iframe>
            </div> 
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
     
        $('#divRss').FeedEk({
            FeedUrl : 'f1news.ru/export/news.xml',
            MaxCount : 5,
            ShowDesc : true,
            ShowPubDate:true,
            DescCharacterLimit:100,
            TitleLinkTarget:'_blank',
            DateFormat : 'dd/MM/yyyy',
            DateFormatLang : 'ru'
        });
     
</script>
<script>
    $(function() {
        $.ajaxSetup({
            cache: false
        });
        $("".addPost"").click(function(e) {

            e.preventDefault();
            $.get(this.href, function(data) {
                $('#dialogContent').html(data);
                $('#modDialog').modal('show');
            });
        });
    })
</script>
<script>
    $(document).ready(function() {
        $('.embeddedVideo').each(function() {
            var video = $(this).attr('src'); // get the current value of the input field.
            if (video.includes('.be/')) {
                var res = video.split(""/"").pop();
         ");
            WriteLiteral(@"   } else {
                var res = video.split(""="").pop();
            }

            var embeddedUrl = ""https://www.youtube.com/embed/"" + res + '?autoplay=0&controls=0&enablejsapi=1&mute=0&loop=1&&playlist=Video_ID';


            $(this).attr('src', embeddedUrl);
            $(this).css('display', 'block');

        });

        $.get('/Home/_GetBestPosts', function(data) {
            $('#popularPartial').html(data);
        });
        $.get('/Home/_GetNewComments', function(data) {
            $('#newCommentsPartial').html(data);
        });


    });
    var player;

    function onYouTubeIframeAPIReady() {
        player = new YT.Player('ytplayer', {
            events: {
                'onReady': onPlayerReady
            }
        });
    }
</script>
<script>
      
    let elem = $('.iframe-link');
    elem.on('click', function(e){
        e.preventDefault();
        alert(elem.attr('href'));
        $('#modalWindow').addClass(""visible""); 
        $('#iframe");
            WriteLiteral(@"-window').attr('src', $(this).attr('href'));
         
        $('#linkToF1').attr('href', $(this).attr('href'))
         
        
    });
    function showModal(self) {
        var modal = document.getElementById('modalWindow');
        modal.style.display = 'block';
        var iframe = modal.getElementsByTagName('iframe')[0];
        $('#iframe-window').attr('src', elem.attr('href'));
        $('#modalWindow').css('display', 'block');
        
        $('.modal-window').css('display', 'block');
        return false;
    }
    $(document).mouseup(function (e) {
        var container = $(""#modalWindow"");
        if (container.has(e.target).length === 0){
            container.hide();
            $('.overlay').hide();
        }
    });
     
</script>
<script type=""text/javascript"">
    function setFocus()
    {
        document.getElementById(""main"").focus();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
