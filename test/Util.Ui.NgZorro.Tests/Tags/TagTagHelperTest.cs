﻿using System;
using System.Text;
using Util.Ui.Angular.Configs;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Tags;
using Util.Ui.NgZorro.Enums;
using Util.Ui.NgZorro.Tests.Samples;
using Util.Ui.TagHelpers;
using Xunit;
using Xunit.Abstractions;

namespace Util.Ui.NgZorro.Tests.Tags {
    /// <summary>
    /// 标签测试
    /// </summary>
    public partial class TagTagHelperTest : IDisposable{
        /// <summary>
        /// 输出工具
        /// </summary>
        private readonly ITestOutputHelper _output;
        /// <summary>
        /// TagHelper包装器
        /// </summary>
        private readonly TagHelperWrapper<Customer> _wrapper;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public TagTagHelperTest( ITestOutputHelper output ) {
            _output = output;
            _wrapper = new TagTagHelper().ToWrapper<Customer>();
            Util.Helpers.Id.SetId( "id" );
        }

        /// <summary>
        /// 测试清理
        /// </summary>
        public void Dispose() {
            Util.Helpers.Id.Reset();
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
            result.Append( "<nz-tag></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试模式
        /// </summary>
        [Fact]
        public void TestMode() {
            _wrapper.SetContextAttribute( UiConst.Mode, TagMode.Checkable );
            var result = new StringBuilder();
            result.Append( "<nz-tag nzMode=\"checkable\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试模式
        /// </summary>
        [Fact]
        public void TestBindMode() {
            _wrapper.SetContextAttribute( AngularConst.BindMode, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-tag [nzMode]=\"a\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试是否选中
        /// </summary>
        [Fact]
        public void TestChecked() {
            _wrapper.SetContextAttribute( UiConst.Checked, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-tag [nzChecked]=\"true\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试是否选中
        /// </summary>
        [Fact]
        public void TestBindonChecked() {
            _wrapper.SetContextAttribute( AngularConst.BindonChecked, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-tag [(nzChecked)]=\"a\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试颜色枚举类型
        /// </summary>
        [Fact]
        public void TestColorType() {
            _wrapper.SetContextAttribute( UiConst.ColorType, TagColor.GeekBlue );
            var result = new StringBuilder();
            result.Append( "<nz-tag nzColor=\"geekblue\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试颜色
        /// </summary>
        [Fact]
        public void TestColor() {
            _wrapper.SetContextAttribute( UiConst.Color, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-tag nzColor=\"a\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试颜色
        /// </summary>
        [Fact]
        public void TestBindColor() {
            _wrapper.SetContextAttribute( AngularConst.BindColor, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-tag [nzColor]=\"a\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试边框
        /// </summary>
        [Fact]
        public void TestBordered() {
            _wrapper.SetContextAttribute( UiConst.Bordered, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-tag [nzBordered]=\"a\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试内容
        /// </summary>
        [Fact]
        public void TestContent() {
            _wrapper.AppendContent( "a" );
            var result = new StringBuilder();
            result.Append( "<nz-tag>a</nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试点击事件
        /// </summary>
        [Fact]
        public void TestOnClick() {
            _wrapper.SetContextAttribute( UiConst.OnClick, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-tag (click)=\"a\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试关闭事件
        /// </summary>
        [Fact]
        public void TestOnClose() {
            _wrapper.SetContextAttribute( UiConst.OnClose, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-tag (nzOnClose)=\"a\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试选中状态变化事件
        /// </summary>
        [Fact]
        public void TestOnCheckedChange() {
            _wrapper.SetContextAttribute( UiConst.OnCheckedChange, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-tag (nzCheckedChange)=\"a\"></nz-tag>" );
            Assert.Equal( result.ToString(), GetResult() );
        }
    }
}