﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteExtensions.Administration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class XdtTemplate : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        #line 3 "..\..\XdtTemplate.cshtml"

    public string Path { get; set; }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n\r\n");


WriteLiteral("\r\n\r\n<?xml version=\"1.0\"?>\r\n<configuration xmlns:xdt=\"http://schemas.microsoft.com" +
"/XML-Document-Transform\">\r\n  <system.applicationHost>\r\n    <sites>\r\n      <site " +
"name=\"%XDT_SCMSITENAME%\" xdt:Locator=\"Match(name)\">\r\n        <application path=\"" +
"/");


            
            #line 12 "..\..\XdtTemplate.cshtml"
                       Write(Path);

            
            #line default
            #line hidden
WriteLiteral("\" xdt:Locator=\"Match(path)\" xdt:Transform=\"Remove\" />\r\n        <application path=" +
"\"/");


            
            #line 13 "..\..\XdtTemplate.cshtml"
                       Write(Path);

            
            #line default
            #line hidden
WriteLiteral("\" applicationPool=\"%XDT_APPPOOLNAME%\" xdt:Transform=\"Insert\">\r\n          <virtual" +
"Directory path=\"/\" physicalPath=\"%XDT_EXTENSIONPATH%\" />\r\n        </application>" +
"\r\n      </site>\r\n    </sites>\r\n  </system.applicationHost>\r\n</configuration>\r\n\r\n" +
"");


        }
    }
}
#pragma warning restore 1591
