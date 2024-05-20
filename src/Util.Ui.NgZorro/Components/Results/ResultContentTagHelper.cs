﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Angular.TagHelpers;
using Util.Ui.NgZorro.Components.Results.Renders;
using Util.Ui.Renders;

namespace Util.Ui.NgZorro.Components.Results; 

/// <summary>
/// 结果内容区,生成的标签为&lt;div nz-result-content>&lt;/div>
/// </summary>
[HtmlTargetElement( "util-result-content" )]
public class ResultContentTagHelper : AngularTagHelperBase {
    /// <inheritdoc />
    protected override IRender GetRender( TagHelperContext context, TagHelperOutput output, TagHelperContent content ) {
        var config = new Config( context, output, content );
        return new ResultContentRender( config );
    }
}