﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Angular.TagHelpers;
using Util.Ui.NgZorro.Components.Templates.Renders;
using Util.Ui.Renders;

namespace Util.Ui.NgZorro.Components.Templates; 

/// <summary>
/// 模板,生成的标签为&lt;ng-template&gt;&lt;/ng-template&gt;
/// </summary>
[HtmlTargetElement( "util-template" )]
public class TemplateTagHelper : AngularTagHelperBase {
    /// <summary>
    /// 扩展属性 nz-tab,选项卡是否延迟加载, 默认值: false
    /// </summary>
    public bool Tab { get; set; }
    /// <summary>
    /// [ngTemplateOutlet], 模板出口
    /// </summary>
    public string NgTemplateOutlet { get; set; }
    /// <summary>
    /// [ngTemplateOutletContext], 模板出口上下文
    /// </summary>
    public string NgTemplateOutletContext { get; set; }

    /// <inheritdoc />
    protected override IRender GetRender( TagHelperContext context, TagHelperOutput output, TagHelperContent content ) {
        var config = new Config( context, output, content );
        return new TemplateRender( config );
    }
}