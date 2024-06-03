﻿using System.Text;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Forms;
using Xunit;

namespace Util.Ui.NgZorro.Tests.Checkboxes {
    /// <summary>
    /// 复选框测试 - 表单结构相关
    /// </summary>
    public partial class CheckboxTagHelperTest {
        /// <summary>
        /// 测试标签文本
        /// </summary>
        [Fact]
        public void TestLabelText() {
            _wrapper.SetContextAttribute( UiConst.LabelText, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-label>a</nz-form-label>" );
            result.Append( "<nz-form-control>" );
            result.Append( "<label nz-checkbox=\"\"></label>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试自动设置nzFor
        /// </summary>
        [Fact]
        public void TestAutoNzFor() {
            var form = new FormTagHelper().ToWrapper();

            var formItem = new FormItemTagHelper().ToWrapper();
            form.AppendContent( formItem );

            var formLabel = new FormLabelTagHelper().ToWrapper();
            formLabel.AppendContent( "a" );
            formItem.AppendContent( formLabel );

            _wrapper.SetContextAttribute( UiConst.AutoNzFor, true );
            var formControl = new FormControlTagHelper().ToWrapper();
            formControl.AppendContent( _wrapper );
            formItem.AppendContent( formControl );

            var result = new StringBuilder();
            result.Append( "<form nz-form=\"\">" );
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-label nzFor=\"control_form_id\">a</nz-form-label>" );
            result.Append( "<nz-form-control>" );
            result.Append( "<label nz-checkbox=\"\" nzId=\"control_form_id\"></label>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            result.Append( "</form>" );
            Assert.Equal( result.ToString(), form.GetResult() );
        }
    }
}
