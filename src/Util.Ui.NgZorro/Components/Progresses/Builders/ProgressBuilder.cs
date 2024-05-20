﻿using Util.Ui.Angular.Builders;
using Util.Ui.Angular.Configs;
using Util.Ui.NgZorro.Directives.Popconfirms;
using Util.Ui.NgZorro.Directives.Popover;
using Util.Ui.NgZorro.Directives.Tooltips;
using Util.Ui.NgZorro.Enums;

namespace Util.Ui.NgZorro.Components.Progresses.Builders; 

/// <summary>
/// 进度条标签生成器
/// </summary>
public class ProgressBuilder : AngularTagBuilder {
    /// <summary>
    /// 配置
    /// </summary>
    private readonly Config _config;

    /// <summary>
    /// 初始化进度条标签生成器
    /// </summary>
    /// <param name="config">配置</param>
    public ProgressBuilder( Config config ) : base( config,"nz-progress" ) {
        _config = config;
    }

    /// <summary>
    /// 配置类型
    /// </summary>
    public ProgressBuilder Type() {
        AttributeIfNotEmpty( "nzType", _config.GetValue<ProgressType?>( UiConst.Type )?.Description() );
        AttributeIfNotEmpty( "[nzType]", _config.GetValue( AngularConst.BindType ) );
        return this;
    }

    /// <summary>
    /// 配置尺寸
    /// </summary>
    public ProgressBuilder Size() {
        AttributeIfNotEmpty( "nzSize", _config.GetValue<ProgressSize?>( UiConst.Size )?.Description() );
        AttributeIfNotEmpty( "[nzSize]", _config.GetValue( AngularConst.BindSize ) );
        return this;
    }

    /// <summary>
    /// 配置格式化函数
    /// </summary>
    public ProgressBuilder Format() {
        AttributeIfNotEmpty( "[nzFormat]", _config.GetValue( UiConst.Format ) );
        return this;
    }

    /// <summary>
    /// 配置百分比
    /// </summary>
    public ProgressBuilder Percent() {
        AttributeIfNotEmpty( "[nzPercent]", _config.GetValue( UiConst.Percent ) );
        return this;
    }

    /// <summary>
    /// 配置是否显示进度信息
    /// </summary>
    public ProgressBuilder ShowInfo() {
        AttributeIfNotEmpty( "[nzShowInfo]", _config.GetValue( UiConst.ShowInfo ) );
        return this;
    }

    /// <summary>
    /// 配置状态
    /// </summary>
    public ProgressBuilder Status() {
        AttributeIfNotEmpty( "nzStatus", _config.GetValue<ProgressStatus?>( UiConst.Status )?.Description() );
        AttributeIfNotEmpty( "[nzStatus]", _config.GetValue( AngularConst.BindStatus ) );
        return this;
    }

    /// <summary>
    /// 配置端点形状
    /// </summary>
    public ProgressBuilder StrokeLinecap() {
        AttributeIfNotEmpty( "nzStrokeLinecap", _config.GetValue<ProgressStrokeLinecap?>( UiConst.StrokeLinecap )?.Description() );
        AttributeIfNotEmpty( "[nzStrokeLinecap]", _config.GetValue( AngularConst.BindStrokeLinecap ) );
        return this;
    }

    /// <summary>
    /// 配置颜色
    /// </summary>
    public ProgressBuilder StrokeColor() {
        AttributeIfNotEmpty( "nzStrokeColor", _config.GetValue<AntDesignColor?>( UiConst.StrokeColorType )?.Description() );
        AttributeIfNotEmpty( "nzStrokeColor", _config.GetValue( UiConst.StrokeColor ) );
        AttributeIfNotEmpty( "[nzStrokeColor]", _config.GetValue( AngularConst.BindStrokeColor ) );
        return this;
    }

    /// <summary>
    /// 配置已完成分段百分比
    /// </summary>
    public ProgressBuilder SuccessPercent() {
        AttributeIfNotEmpty( "[nzSuccessPercent]", _config.GetValue( UiConst.SuccessPercent ) );
        return this;
    }

    /// <summary>
    /// 配置线条宽度
    /// </summary>
    public ProgressBuilder StrokeWidth() {
        AttributeIfNotEmpty( "[nzStrokeWidth]", _config.GetValue( UiConst.StrokeWidth ) );
        return this;
    }

    /// <summary>
    /// 配置总步数
    /// </summary>
    public ProgressBuilder Steps() {
        AttributeIfNotEmpty( "[nzSteps]", _config.GetValue( UiConst.Steps ) );
        return this;
    }

    /// <summary>
    /// 配置画布宽度
    /// </summary>
    public ProgressBuilder Width() {
        AttributeIfNotEmpty( "[nzWidth]", _config.GetValue( UiConst.Width ) );
        return this;
    }

    /// <summary>
    /// 配置缺口角度
    /// </summary>
    public ProgressBuilder GapDegree() {
        AttributeIfNotEmpty( "[nzGapDegree]", _config.GetValue( UiConst.GapDegree ) );
        return this;
    }

    /// <summary>
    /// 配置缺口位置
    /// </summary>
    public ProgressBuilder GapPosition() {
        AttributeIfNotEmpty( "nzGapPosition", _config.GetValue<ProgressGapPosition?>( UiConst.GapPosition )?.Description() );
        AttributeIfNotEmpty( "[nzGapPosition]", _config.GetValue( AngularConst.BindGapPosition ) );
        return this;
    }

    /// <summary>
    /// 配置
    /// </summary>
    public override void Config() {
        base.Config();
        this.Tooltip( _config ).Popover( _config ).Popconfirm( _config );
        Type().Size().Format().Percent().ShowInfo().Status().StrokeLinecap()
            .StrokeColor().SuccessPercent().StrokeWidth().Steps().Width()
            .GapDegree().GapPosition();
    }
}