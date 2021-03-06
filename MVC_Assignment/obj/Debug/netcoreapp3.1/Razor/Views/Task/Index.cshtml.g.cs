#pragma checksum "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89c8180192981e958fd0970bfadc210ed0578496"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
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
#line 1 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\_ViewImports.cshtml"
using MVC_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\_ViewImports.cshtml"
using MVC_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c8180192981e958fd0970bfadc210ed0578496", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05e3f456cb7a24d8fc230081490d890f1de6c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Assignment.Models.TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
  
    var assigneesNameList = new List<SelectListItem>() { new SelectListItem() { Text = "Select", Value = "-1" } };

    if (Model.AssigneeNameList != null)
    {
        foreach (var assignee in Model.AssigneeNameList)
        {
            assigneesNameList.Add(new SelectListItem() { Text = assignee, Value = assignee });
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    table {
        border: 2px solid;
        margin-top:25px;
    }

    th, td {
        padding: 15px;
        text-align: left;
    }
    .create{
        margin-left:20px;
    }
    .btn {
        margin-left: 20px;
        border-radius: 12px;
        background-color: #e7e7e7;
        color: black;
    }
</style>

<div class=""create"">

    ");
#nullable restore
#line 36 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
Write(Html.ActionLink("Create Task", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 39 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label for=\"AssigneeNameList\">Assignee :</label>\r\n");
#nullable restore
#line 42 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
   Write(Html.DropDownListFor(t => t.SelectedAssignee, assigneesNameList));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Load\" class=\"btn\"/>\r\n");
#nullable restore
#line 45 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n<table>\r\n    <tr>\r\n        <th>taskid</th>\r\n        <th>Title</th>\r\n        <th>Description</th>\r\n        <th>Assignee</th>\r\n        <th>Complitation_Date</th>\r\n        <th>Action</th>\r\n    </tr>\r\n");
#nullable restore
#line 58 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
     foreach (var tasks in Model.TasksList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 61 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
           Write(tasks.TaskId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 62 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
           Write(tasks.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 63 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
           Write(tasks.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 64 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
           Write(tasks.AssigneeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 65 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
           Write(tasks.Complitation_Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            <td>");
#nullable restore
#line 68 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
           Write(Html.ActionLink("Edit Task", "Edit", new { id = tasks.TaskId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 70 "D:\Users\akazi\Desktop\Assignments\Solve-Assignments\MVC_Assignment\Views\Task\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Assignment.Models.TaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
