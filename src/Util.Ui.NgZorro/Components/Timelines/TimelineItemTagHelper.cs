﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Angular.TagHelpers;
using Util.Ui.NgZorro.Components.Timelines.Renders;
using Util.Ui.NgZorro.Enums;
using Util.Ui.Renders;

namespace Util.Ui.NgZorro.Components.Timelines; 

/// <summary>
/// 时间轴节点,生成的标签为&lt;nz-timeline-item>&lt;/nz-timeline-item>
/// </summary>
[HtmlTargetElement( "util-timeline-item" )]
public class TimelineItemTagHelper : AngularTagHelperBase {
    /// <summary>
    /// nzColor,扩展属性,指定圆圈颜色
    /// </summary>
    public AntDesignColor ColorType { get; set; }
    /// <summary>
    /// nzColor,指定圆圈颜色,范例: 'blue' | 'red' | 'green' | 'gray' ,默认值: 'blue'
    /// </summary>
    public string Color { get; set; }
    /// <summary>
    /// [nzColor],指定圆圈颜色,范例: 'blue' | 'red' | 'green' | 'gray' ,默认值: 'blue'
    /// </summary>
    public string BindColor { get; set; }
    /// <summary>
    /// [nzDot],自定义时间轴点,类型: string | TemplateRef&lt;void>
    /// </summary>
    public string Dot { get; set; }
    /// <summary>
    /// nzPosition,自定义节点位置，仅当时间轴的 nzMode 为 custom 时有效,可选值: 'left' | 'right'
    /// </summary>
    public TimelineItemPosition Position { get; set; }
    /// <summary>
    /// [nzPosition],自定义节点位置，仅当时间轴的 nzMode 为 custom 时有效,可选值: 'left' | 'right'
    /// </summary>
    public string BindPosition { get; set; }
    /// <summary>
    /// nzLabel,设置标签,用于单独显示时间
    /// </summary>
    public string Label { get; set; }
    /// <summary>
    /// [nzLabel],设置标签,用于单独显示时间, 类型: string | TemplateRef&lt;void>
    /// </summary>
    public string BindLabel { get; set; }

    /// <inheritdoc />
    protected override IRender GetRender( TagHelperContext context, TagHelperOutput output, TagHelperContent content ) {
        var config = new Config( context, output, content );
        return new TimelineItemRender( config );
    }
}