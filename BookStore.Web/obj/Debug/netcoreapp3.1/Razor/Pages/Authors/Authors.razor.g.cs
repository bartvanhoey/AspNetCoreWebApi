#pragma checksum "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05ef0e3f4d5c5c80d6373686d242d955f5978534"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.Web.Pages.Authors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using BookStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using BookStore.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using BookStore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\_Data\AspNetCoreWebApi\BookStore.Web\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class Authors : AuthorsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3><b>Enter Author Information</b></h3>\r\n    <hr>\r\n\r\n   ");
            __builder.OpenComponent<BookStore.Components.ServerValidations>(4);
            __builder.AddAttribute(5, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                 IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Result", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                                    Result

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        Author: ");
                __builder2.AddContent(9, 
#nullable restore
#line 10 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                 RecordName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, "\r\n   ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n     ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                       Author

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                               SaveAuthorAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n         ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-12 row");
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.AddMarkupContent(22, "<label for=\"firstName\" class=\"col-2 font-weight-bold\">First Name</label>\r\n            ");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "id", "firstName");
                __builder2.AddAttribute(25, "placeholder", "First Name");
                __builder2.AddAttribute(26, "class", "form-control col-3");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                                             Author.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Author.FirstName = __value, Author.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddElementReferenceCapture(29, (__value) => {
#nullable restore
#line 18 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                         firstNameRef = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __Blazor.BookStore.Web.Pages.Authors.Authors.TypeInference.CreateValidationMessage_0(__builder2, 31, 32, 
#nullable restore
#line 19 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                      () => Author.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-12 row");
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.AddMarkupContent(38, "<label for=\"lastName\" class=\"col-2 font-weight-bold\">Last Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "lastName");
                __builder2.AddAttribute(41, "placeholder", "Last Name");
                __builder2.AddAttribute(42, "class", "form-control col-3");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                                  Author.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Author.LastName = __value, Author.LastName))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Author.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __Blazor.BookStore.Web.Pages.Authors.Authors.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 25 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                      () => Author.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-12 row");
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.AddMarkupContent(54, "<label for=\"city\" class=\"col-2 font-weight-bold\">City</label>\r\n            ");
                __builder2.OpenComponent<BookStore.Components.SelectCity>(55);
                __builder2.AddAttribute(56, "OnChangeEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                       OnSelectCityChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n\r\n        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-12 row");
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.AddMarkupContent(62, "<label for=\"emailAddress\" class=\"col-2 font-weight-bold\">Email Address</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "id", "emailAddress");
                __builder2.AddAttribute(65, "placeholder", "Email Address");
                __builder2.AddAttribute(66, "class", "form-control col-3");
                __builder2.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                                      Author.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Author.EmailAddress = __value, Author.EmailAddress))));
                __builder2.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Author.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __Blazor.BookStore.Web.Pages.Authors.Authors.TypeInference.CreateValidationMessage_2(__builder2, 71, 72, 
#nullable restore
#line 36 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                      () => Author.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(75, @"<div class=""col-12 row"">
            <span class=""col-2""></span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Save"">
            <span>&nbsp;</span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Clear"">
        </div>
     ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, " \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n<br>\r\n");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-10");
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 50 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
 if (Authors != null && Authors.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "   ");
            __builder.OpenElement(82, "table");
            __builder.AddAttribute(83, "class", "table");
            __builder.AddMarkupContent(84, "\r\n       ");
            __builder.AddMarkupContent(85, @"<thead>
           <tr>
               <th>AuthorId</th>
               <th>First Name</th>
               <th>Last Name</th>
               <th>City</th>
               <th>Email Address</th>
               <th></th>
           </tr>
       </thead>
       ");
            __builder.OpenElement(86, "tbody");
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 64 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
         foreach (var author in Authors)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "            ");
            __builder.OpenElement(89, "tr");
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(92);
            __builder.AddAttribute(93, "href", 
#nullable restore
#line 67 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                   string.Format("/authors/authordetails/{0}", @author.AuthorId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(95, 
#nullable restore
#line 67 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                                                                                  author.AuthorId

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "td");
            __builder.AddContent(98, 
#nullable restore
#line 68 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                     author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.OpenElement(100, "td");
            __builder.AddContent(101, 
#nullable restore
#line 69 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                     author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.OpenElement(103, "td");
            __builder.AddContent(104, 
#nullable restore
#line 70 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                     author.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "td");
            __builder.AddContent(107, 
#nullable restore
#line 71 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                     author.EmailAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "td");
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.OpenElement(111, "a");
            __builder.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                 (() => DeleteAuthor(author.AuthorId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(113, "style", "text-underline-position:below;cursor:pointer;color:blue;font-weight: bold;");
            __builder.AddContent(114, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "  |\r\n                    ");
            __builder.OpenElement(116, "a");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
                                 (() => EditAuthor(author))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "style", "text-underline-position:below;cursor:pointer;color:blue;font-weight: bold;");
            __builder.AddContent(119, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, " \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 77 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "       ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n   ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n");
#nullable restore
#line 80 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
}
else 
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(126, "     ");
            __builder.OpenComponent<BookStore.Components.NoResultMessage>(127);
            __builder.CloseComponent();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 84 "C:\_Data\AspNetCoreWebApi\BookStore.Web\Pages\Authors\Authors.razor"
}    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BookStore.Web.Pages.Authors.Authors
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591