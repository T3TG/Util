﻿using System.Text;
using Util.Ui.NgZorro.Components.Forms.Configs;
using Util.Ui.NgZorro.Configs;
using Xunit;

namespace Util.Ui.NgZorro.Tests.Radios {
    /// <summary>
    /// 单选框测试 - 表达式解析测试
    /// </summary>
    public partial class RadioTagHelperTest {
        /// <summary>
        /// 测试属性表达式 - 布尔值
        /// </summary>
        [Fact]
        public void TestFor_Bool() {
            _wrapper.SetItem( new FormShareConfig { FormCreated = true } );
            _wrapper.SetExpression( t => t.Enabled );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-label>" );
            result.Append( "启用" );
            result.Append( "</nz-form-label>" );
            result.Append( "<nz-form-control>" );
            result.Append( "<nz-radio-group #x_enabled=\"xSelectExtend\" name=\"enabled\" nzName=\"enabled\" x-select-extend=\"\" [(ngModel)]=\"model.enabled\" " );
            result.Append( "[data]=\"[{'text':'是','value':true,'sortId':1},{'text':'否','value':false,'sortId':2}]\"" );
            result.Append( ">" );
            result.Append( "@for(item of x_enabled.options;track item.value ){" );
            result.Append( "<label #enabled=\"\" nz-radio=\"\" [nzDisabled]=\"item.disabled\" [nzValue]=\"item.value\">" );
            result.Append( "{{item.text}}" );
            result.Append( "</label>" );
            result.Append( "}" );
            result.Append( "</nz-radio-group>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试属性表达式 - 布尔值 - 多语言
        /// </summary>
        [Fact]
        public void TestFor_Bool_2() {
            _wrapper.SetItem( new FormShareConfig { FormCreated = true } );
            NgZorroOptionsService.SetOptions( new NgZorroOptions { EnableI18n = true } );
            _wrapper.SetExpression( t => t.Enabled );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-label>" );
            result.Append( "{{'启用'|i18n}}" );
            result.Append( "</nz-form-label>" );
            result.Append( "<nz-form-control>" );
            result.Append( "<nz-radio-group #x_enabled=\"xSelectExtend\" name=\"enabled\" nzName=\"enabled\" x-select-extend=\"\" [(ngModel)]=\"model.enabled\" " );
            result.Append( "[data]=\"[{'text':'util.yes','value':true,'sortId':1},{'text':'util.no','value':false,'sortId':2}]\"" );
            result.Append( ">" );
            result.Append( "@for(item of x_enabled.options;track item.value ){" );
            result.Append( "<label #enabled=\"\" nz-radio=\"\" [nzDisabled]=\"item.disabled\" [nzValue]=\"item.value\">" );
            result.Append( "{{item.text|i18n}}" );
            result.Append( "</label>" );
            result.Append( "}" );
            result.Append( "</nz-radio-group>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试属性表达式 - 布尔值 - 必填项
        /// </summary>
        [Fact]
        public void TestFor_Bool_3() {
            _wrapper.SetItem( new FormShareConfig { FormCreated = true } );
            _wrapper.SetExpression( t => t.IsRequired );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-label [nzRequired]=\"true\">" );
            result.Append( "必填项" );
            result.Append( "</nz-form-label>" );
            result.Append( "<nz-form-control [nzErrorTip]=\"vt_is_required\">" );
            result.Append( "<nz-radio-group #v_is_required=\"xValidationExtend\" #x_is_required=\"xSelectExtend\" displayName=\"必填项\" name=\"is_required\" nzName=\"is_required\" " );
            result.Append( "requiredMessage=\"必须填写\" x-select-extend=\"\" x-validation-extend=\"\" [(ngModel)]=\"model.isRequired\" " );
            result.Append( "[data]=\"[{'text':'是','value':true,'sortId':1},{'text':'否','value':false,'sortId':2}]\" [required]=\"true\"" );
            result.Append( ">" );
            result.Append( "@for(item of x_is_required.options;track item.value ){" );
            result.Append( "<label #is_required=\"\" nz-radio=\"\" [nzDisabled]=\"item.disabled\" [nzValue]=\"item.value\">" );
            result.Append( "{{item.text}}" );
            result.Append( "</label>" );
            result.Append( "}" );
            result.Append( "</nz-radio-group>" );
            result.Append( "<ng-template #vt_is_required=\"\">{{v_is_required.getErrorMessage()}}</ng-template>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试属性表达式 - 枚举值
        /// </summary>
        [Fact]
        public void TestFor_Enum() {
            _wrapper.SetItem( new FormShareConfig { FormCreated = true } );
            _wrapper.SetExpression( t => t.Gender );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-label>" );
            result.Append( "性别" );
            result.Append( "</nz-form-label>" );
            result.Append( "<nz-form-control>" );
            result.Append( "<nz-radio-group #x_gender=\"xSelectExtend\" name=\"gender\" nzName=\"gender\" x-select-extend=\"\" [(ngModel)]=\"model.gender\" " );
            result.Append( "[data]=\"[{'text':'util.female','value':1,'sortId':1},{'text':'util.male','value':2,'sortId':2}]\"" );
            result.Append( ">" );
            result.Append( "@for(item of x_gender.options;track item.value ){" );
            result.Append( "<label #gender=\"\" nz-radio=\"\" [nzDisabled]=\"item.disabled\" [nzValue]=\"item.value\">" );
            result.Append( "{{item.text}}" );
            result.Append( "</label>" );
            result.Append( "}" );
            result.Append( "</nz-radio-group>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试属性表达式 - 枚举值 - 多语言
        /// </summary>
        [Fact]
        public void TestFor_Enum_I18n() {
            _wrapper.SetItem( new FormShareConfig { FormCreated = true } );
            NgZorroOptionsService.SetOptions( new NgZorroOptions { EnableI18n = true } );
            _wrapper.SetExpression( t => t.Gender );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-label>" );
            result.Append( "{{'性别'|i18n}}" );
            result.Append( "</nz-form-label>" );
            result.Append( "<nz-form-control>" );
            result.Append( "<nz-radio-group #x_gender=\"xSelectExtend\" name=\"gender\" nzName=\"gender\" x-select-extend=\"\" [(ngModel)]=\"model.gender\" " );
            result.Append( "[data]=\"[{'text':'util.female','value':1,'sortId':1},{'text':'util.male','value':2,'sortId':2}]\"" );
            result.Append( ">" );
            result.Append( "@for(item of x_gender.options;track item.value ){" );
            result.Append( "<label #gender=\"\" nz-radio=\"\" [nzDisabled]=\"item.disabled\" [nzValue]=\"item.value\">" );
            result.Append( "{{item.text|i18n}}" );
            result.Append( "</label>" );
            result.Append( "}" );
            result.Append( "</nz-radio-group>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }
    }
}
