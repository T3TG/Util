﻿using Util.Ui.NgZorro.Components.Forms.Helpers;

namespace Util.Ui.NgZorro.Components.Inputs.Helpers;

/// <summary>
/// 输入框服务
/// </summary>
public class InputService {
    /// <summary>
    /// 配置
    /// </summary>
    private readonly Config _config;
    /// <summary>
    /// 输入框组样式类
    /// </summary>
    private readonly string _inputGroupClass;

    /// <summary>
    /// 初始化输入框服务
    /// </summary>
    /// <param name="config">配置</param>
    /// <param name="inputGroupClass">输入框组样式类</param>
    public InputService( Config config, string inputGroupClass = null ) {
        _config = config;
        _inputGroupClass = inputGroupClass;
    }

    /// <summary>
    /// 初始化
    /// </summary>
    public void Init() {
        LoadExpression();
        InitValidationService();
        InitFormShareService();
        InitFormItemShareService();
        InitInputGroupShareService();
    }

    /// <summary>
    /// 加载表达式
    /// </summary>
    private void LoadExpression() {
        var loader = new InputExpressionLoader();
        loader.Load( _config );
    }

    /// <summary>
    /// 初始化验证服务
    /// </summary>
    private void InitValidationService() {
        var service = new ValidationService( _config );
        service.Init();
    }

    /// <summary>
    /// 初始化表单共享服务
    /// </summary>
    private void InitFormShareService() {
        var service = new FormShareService( _config );
        service.Init();
    }

    /// <summary>
    /// 初始化表单项共享服务
    /// </summary>
    private void InitFormItemShareService() {
        var service = new FormItemShareService( _config );
        service.Init();
        service.InitId();
    }

    /// <summary>
    /// 初始化输入框组合共享服务
    /// </summary>
    private void InitInputGroupShareService() {
        var service = new InputGroupShareService( _config );
        service.Init();
        service.SetInputId( GetId() );
        service.SetClass( _inputGroupClass );
    }

    /// <summary>
    /// 获取输入框标识
    /// </summary>
    private string GetId() {
        var id = _config.GetValue( UiConst.Id );
        return id.IsEmpty() ? Util.Helpers.Id.Create() : id;
    }
}