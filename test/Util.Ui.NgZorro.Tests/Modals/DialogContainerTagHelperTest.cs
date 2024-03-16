﻿using System.Text;
using Util.Ui.Angular.Configs;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Drawers;
using Util.Ui.NgZorro.Components.Modals;
using Util.Ui.TagHelpers;
using Xunit;
using Xunit.Abstractions;

namespace Util.Ui.NgZorro.Tests.Modals;

/// <summary>
/// 对话框容器测试
/// </summary>
public class DialogContainerTagHelperTest {
    /// <summary>
    /// 输出工具
    /// </summary>
    private readonly ITestOutputHelper _output;
    /// <summary>
    /// TagHelper包装器
    /// </summary>
    private readonly TagHelperWrapper _wrapper;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public DialogContainerTagHelperTest( ITestOutputHelper output ) {
        _output = output;
        _wrapper = new DialogContainerTagHelper().ToWrapper();
    }

    /// <summary>
    /// 获取结果
    /// </summary>
    private string GetResult() {
        var result = _wrapper.GetResult();
        _output.WriteLine( result );
        return result;
    }

    /// <summary>
    /// 测试默认输出
    /// </summary>
    [Fact]
    public void TestDefault() {
        var result = new StringBuilder();
        result.Append( "<x-dialog-container></x-dialog-container>" );
        Assert.Equal( result.ToString(), GetResult() );
    }

    /// <summary>
    /// 测试最小宽度
    /// </summary>
    [Fact]
    public void TestMinWidth() {
        _wrapper.SetContextAttribute( UiConst.MinWidth, 1 );
        var result = new StringBuilder();
        result.Append( "<x-dialog-container minWidth=\"1\"></x-dialog-container>" );
        Assert.Equal( result.ToString(), GetResult() );
    }

    /// <summary>
    /// 测试最小宽度
    /// </summary>
    [Fact]
    public void TestBindMinWidth() {
        _wrapper.SetContextAttribute( AngularConst.BindMinWidth, "a" );
        var result = new StringBuilder();
        result.Append( "<x-dialog-container [minWidth]=\"a\"></x-dialog-container>" );
        Assert.Equal( result.ToString(), GetResult() );
    }

    /// <summary>
    /// 测试最大宽度
    /// </summary>
    [Fact]
    public void TestMaxWidth() {
        _wrapper.SetContextAttribute( UiConst.MaxWidth, 1 );
        var result = new StringBuilder();
        result.Append( "<x-dialog-container maxWidth=\"1\"></x-dialog-container>" );
        Assert.Equal( result.ToString(), GetResult() );
    }

    /// <summary>
    /// 测试最大宽度
    /// </summary>
    [Fact]
    public void TestBindMaxWidth() {
        _wrapper.SetContextAttribute( AngularConst.BindMaxWidth, "a" );
        var result = new StringBuilder();
        result.Append( "<x-dialog-container [maxWidth]=\"a\"></x-dialog-container>" );
        Assert.Equal( result.ToString(), GetResult() );
    }

    /// <summary>
    /// 测试内容
    /// </summary>
    [Fact]
    public void TestContent() {
        _wrapper.AppendContent( "a" );
        var result = new StringBuilder();
        result.Append( "<x-dialog-container>a</x-dialog-container>" );
        Assert.Equal( result.ToString(), GetResult() );
    }
}