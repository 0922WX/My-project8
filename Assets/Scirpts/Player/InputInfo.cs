using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InputInfo;

/// <summary>
/// 输入信息类
/// 用于存储和管理键盘和鼠标的输入信息
/// </summary>
public class InputInfo : MonoBehaviour
{
    #region
    public enum E_KeyOrMouse
    {
        /// <summary>
        /// 键盘输入
        /// </summary>
        Key,
        /// <summary>
        /// 鼠标输入
        /// </summary>
        Mouse,
    }
    public enum E_InputType
    {
        /// <summary>
        /// 按下
        /// </summary>
        Down,
        /// <summary>
        /// 抬起
        /// </summary>
        Up,
        /// <summary>
        /// 长按
        /// </summary>
        Always,
    }
    #endregion

    #region
    /// <summary>
    /// 具体输入键盘/鼠标
    /// </summary>
    public E_KeyOrMouse keyOrMouse;

    /// <summary>
    /// 输入类型-抬起，按下，长按
    /// </summary>
    public E_InputType inputType;

    /// <summary>
    /// keyCode
    /// </summary>
    public KeyCode key;

    /// <summary>
    /// mouseID
    /// </summary>
    public int mouseID;

    #endregion

    #region 构造函数

    /// <summary>
    /// 主要给键盘输入初始化
    /// </summary>
    /// <param name="inputType">输入类型</param>
    /// <param name="key">按键代码</param>
    public InputInfo(E_InputType inputType, KeyCode key)
    {
        this.keyOrMouse = E_KeyOrMouse.Key;
        this.inputType = inputType;
        this.key = key;
    }
    /// <summary>
    /// 主要给鼠标输入初始化
    /// </summary>
    /// <param name="inputType">输入类型</param>
    /// <param name="mouseID">鼠标按键ID</param>
    public InputInfo(E_InputType inputType, int mouseID)
    {
        this.keyOrMouse = E_KeyOrMouse.Mouse;
        this.inputType = inputType;
        this.mouseID = mouseID;
    }
    #endregion
}
