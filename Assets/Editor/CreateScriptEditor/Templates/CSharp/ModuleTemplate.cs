﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleTemplate : ModuleBase
{
    #region 变量声明
    #endregion

    #region 构造器
    public ModuleTemplate(ModuleType moduleType) : base(moduleType)
    {
    }
    #endregion

    /// <summary>
    /// 销毁系统
    /// </summary>
    public override void Exit()
    {
        base.Exit();
    }

    /// <summary>
    /// 初始化模块
    /// </summary>
    public override void Init()
    {
        base.Init();
    }

    /// <summary>
    /// 在这里统一注册监听某个事件
    /// </summary>
    protected override void AddModuleListener()
    {
        base.AddModuleListener();
    }

    /// <summary>
    /// 重置系统时调用
    /// </summary>
    protected override void OnReset()
    {
        base.OnReset();
    }

    /// <summary>
    /// 在这里统一注册监听某个事件
    /// </summary>
    protected override void RemoveModuleListener()
    {
        base.RemoveModuleListener();
    }
}
