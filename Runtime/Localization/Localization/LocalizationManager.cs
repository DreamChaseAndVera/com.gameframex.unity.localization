﻿// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using System;
using System.Collections.Generic;
using GameFrameX.Runtime;
using UnityEngine.Scripting;

namespace GameFrameX.Localization.Runtime
{
    /// <summary>
    /// 本地化管理器。
    /// </summary>
    [Preserve]
    public sealed partial class LocalizationManager : GameFrameworkModule, ILocalizationManager
    {
        private readonly Dictionary<string, string> _dictionary;
        private ILocalizationHelper _localizationHelper;
        private string _defaultLanguage;
        private string _language;

        /// <summary>
        /// 未知本地化
        /// </summary>
        const string UnknownLocalization = "zxx";

        /// <summary>
        /// 初始化本地化管理器的新实例。
        /// </summary>
        [Preserve]
        public LocalizationManager()
        {
            _dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
            _localizationHelper = null;
            _defaultLanguage = UnknownLocalization;
            _language = UnknownLocalization;
        }

        /// <summary>
        /// 获取或设置 默认本地化语言。当加载本地化失败时使用。
        /// </summary>
        [Preserve]
        public string DefaultLanguage
        {
            get { return _defaultLanguage; }
            set
            {
                if (value == UnknownLocalization)
                {
                    throw new GameFrameworkException("default Language is invalid.");
                }

                _defaultLanguage = value;
            }
        }

        /// <summary>
        /// 获取或设置本地化语言。
        /// </summary>
        [Preserve]
        public string Language
        {
            get { return _language; }
            set
            {
                if (value == UnknownLocalization)
                {
                    throw new GameFrameworkException("Language is invalid.");
                }

                _language = value;
            }
        }

        /// <summary>
        /// 获取系统语言。
        /// </summary>
        [Preserve]
        public string SystemLanguage
        {
            get
            {
                GameFrameworkGuard.NotNull(_localizationHelper, nameof(_localizationHelper));
                return _localizationHelper.SystemLanguage;
            }
        }

        /// <summary>
        /// 获取字典数量。
        /// </summary>
        [Preserve]
        public int DictionaryCount
        {
            get { return _dictionary.Count; }
        }

        /// <summary>
        /// 设置本地化辅助器。
        /// </summary>
        /// <param name="localizationHelper">本地化辅助器。</param>
        [Preserve]
        public void SetLocalizationHelper(ILocalizationHelper localizationHelper)
        {
            GameFrameworkGuard.NotNull(localizationHelper, nameof(localizationHelper));
            _localizationHelper = localizationHelper;
        }

        /// <summary>
        /// 本地化管理器轮询。
        /// </summary>
        /// <param name="elapseSeconds">逻辑流逝时间，以秒为单位。</param>
        /// <param name="realElapseSeconds">真实流逝时间，以秒为单位。</param>
        [Preserve]
        protected override void Update(float elapseSeconds, float realElapseSeconds)
        {
        }

        /// <summary>
        /// 关闭并清理本地化管理器。
        /// </summary>
        [Preserve]
        protected override void Shutdown()
        {
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <param name="key">字典主键。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString(string key)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            return value;
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <param name="key">字典主键。</param>
        /// <param name="args">参数列表.</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString(string key, params object[] args)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            return Utility.Text.Format(value, args);
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T">字典参数的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg">字典参数。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T>(string key, T arg)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3}", key, value, arg, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2>(string key, T1 arg1, T2 arg2)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4}", key, value, arg1, arg2, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3>(string key, T1 arg1, T2 arg2, T3 arg3)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5}", key, value, arg1, arg2, arg3, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6}", key, value, arg1, arg2, arg3, arg4, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6},{7}", key, value, arg1, arg2, arg3, arg4, arg5, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6},{7},{8}", key, value, arg1, arg2, arg3, arg4, arg5, arg6, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", key, value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <typeparam name="T8">字典参数 8 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <param name="arg8">字典参数 8。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7, T8>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", key, value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <typeparam name="T8">字典参数 8 的类型。</typeparam>
        /// <typeparam name="T9">字典参数 9 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <param name="arg8">字典参数 8。</param>
        /// <param name="arg9">字典参数 9。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", key, value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <typeparam name="T8">字典参数 8 的类型。</typeparam>
        /// <typeparam name="T9">字典参数 9 的类型。</typeparam>
        /// <typeparam name="T10">字典参数 10 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <param name="arg8">字典参数 8。</param>
        /// <param name="arg9">字典参数 9。</param>
        /// <param name="arg10">字典参数 10。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}", key, value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <typeparam name="T8">字典参数 8 的类型。</typeparam>
        /// <typeparam name="T9">字典参数 9 的类型。</typeparam>
        /// <typeparam name="T10">字典参数 10 的类型。</typeparam>
        /// <typeparam name="T11">字典参数 11 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <param name="arg8">字典参数 8。</param>
        /// <param name="arg9">字典参数 9。</param>
        /// <param name="arg10">字典参数 10。</param>
        /// <param name="arg11">字典参数 11。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", key, value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <typeparam name="T8">字典参数 8 的类型。</typeparam>
        /// <typeparam name="T9">字典参数 9 的类型。</typeparam>
        /// <typeparam name="T10">字典参数 10 的类型。</typeparam>
        /// <typeparam name="T11">字典参数 11 的类型。</typeparam>
        /// <typeparam name="T12">字典参数 12 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <param name="arg8">字典参数 8。</param>
        /// <param name="arg9">字典参数 9。</param>
        /// <param name="arg10">字典参数 10。</param>
        /// <param name="arg11">字典参数 11。</param>
        /// <param name="arg12">字典参数 12。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}", key, value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <typeparam name="T8">字典参数 8 的类型。</typeparam>
        /// <typeparam name="T9">字典参数 9 的类型。</typeparam>
        /// <typeparam name="T10">字典参数 10 的类型。</typeparam>
        /// <typeparam name="T11">字典参数 11 的类型。</typeparam>
        /// <typeparam name="T12">字典参数 12 的类型。</typeparam>
        /// <typeparam name="T13">字典参数 13 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <param name="arg8">字典参数 8。</param>
        /// <param name="arg9">字典参数 9。</param>
        /// <param name="arg10">字典参数 10。</param>
        /// <param name="arg11">字典参数 11。</param>
        /// <param name="arg12">字典参数 12。</param>
        /// <param name="arg13">字典参数 13。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }
            catch (Exception exception)
            {
                return Utility.Text.Format("<Error>{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", key, value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <typeparam name="T8">字典参数 8 的类型。</typeparam>
        /// <typeparam name="T9">字典参数 9 的类型。</typeparam>
        /// <typeparam name="T10">字典参数 10 的类型。</typeparam>
        /// <typeparam name="T11">字典参数 11 的类型。</typeparam>
        /// <typeparam name="T12">字典参数 12 的类型。</typeparam>
        /// <typeparam name="T13">字典参数 13 的类型。</typeparam>
        /// <typeparam name="T14">字典参数 14 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <param name="arg8">字典参数 8。</param>
        /// <param name="arg9">字典参数 9。</param>
        /// <param name="arg10">字典参数 10。</param>
        /// <param name="arg11">字典参数 11。</param>
        /// <param name="arg12">字典参数 12。</param>
        /// <param name="arg13">字典参数 13。</param>
        /// <param name="arg14">字典参数 14。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }
            catch (Exception exception)
            {
                var args = Utility.Text.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                return Utility.Text.Format("<Error>{0},{1},{2},{3}", key, value, args, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <typeparam name="T8">字典参数 8 的类型。</typeparam>
        /// <typeparam name="T9">字典参数 9 的类型。</typeparam>
        /// <typeparam name="T10">字典参数 10 的类型。</typeparam>
        /// <typeparam name="T11">字典参数 11 的类型。</typeparam>
        /// <typeparam name="T12">字典参数 12 的类型。</typeparam>
        /// <typeparam name="T13">字典参数 13 的类型。</typeparam>
        /// <typeparam name="T14">字典参数 14 的类型。</typeparam>
        /// <typeparam name="T15">字典参数 15 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <param name="arg8">字典参数 8。</param>
        /// <param name="arg9">字典参数 9。</param>
        /// <param name="arg10">字典参数 10。</param>
        /// <param name="arg11">字典参数 11。</param>
        /// <param name="arg12">字典参数 12。</param>
        /// <param name="arg13">字典参数 13。</param>
        /// <param name="arg14">字典参数 14。</param>
        /// <param name="arg15">字典参数 15。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            }
            catch (Exception exception)
            {
                var args = Utility.Text.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}", arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                return Utility.Text.Format("<Error>{0},{1},{2},{3}", key, value, args, exception);
            }
        }

        /// <summary>
        /// 根据字典主键获取字典内容字符串。
        /// </summary>
        /// <typeparam name="T1">字典参数 1 的类型。</typeparam>
        /// <typeparam name="T2">字典参数 2 的类型。</typeparam>
        /// <typeparam name="T3">字典参数 3 的类型。</typeparam>
        /// <typeparam name="T4">字典参数 4 的类型。</typeparam>
        /// <typeparam name="T5">字典参数 5 的类型。</typeparam>
        /// <typeparam name="T6">字典参数 6 的类型。</typeparam>
        /// <typeparam name="T7">字典参数 7 的类型。</typeparam>
        /// <typeparam name="T8">字典参数 8 的类型。</typeparam>
        /// <typeparam name="T9">字典参数 9 的类型。</typeparam>
        /// <typeparam name="T10">字典参数 10 的类型。</typeparam>
        /// <typeparam name="T11">字典参数 11 的类型。</typeparam>
        /// <typeparam name="T12">字典参数 12 的类型。</typeparam>
        /// <typeparam name="T13">字典参数 13 的类型。</typeparam>
        /// <typeparam name="T14">字典参数 14 的类型。</typeparam>
        /// <typeparam name="T15">字典参数 15 的类型。</typeparam>
        /// <typeparam name="T16">字典参数 16 的类型。</typeparam>
        /// <param name="key">字典主键。</param>
        /// <param name="arg1">字典参数 1。</param>
        /// <param name="arg2">字典参数 2。</param>
        /// <param name="arg3">字典参数 3。</param>
        /// <param name="arg4">字典参数 4。</param>
        /// <param name="arg5">字典参数 5。</param>
        /// <param name="arg6">字典参数 6。</param>
        /// <param name="arg7">字典参数 7。</param>
        /// <param name="arg8">字典参数 8。</param>
        /// <param name="arg9">字典参数 9。</param>
        /// <param name="arg10">字典参数 10。</param>
        /// <param name="arg11">字典参数 11。</param>
        /// <param name="arg12">字典参数 12。</param>
        /// <param name="arg13">字典参数 13。</param>
        /// <param name="arg14">字典参数 14。</param>
        /// <param name="arg15">字典参数 15。</param>
        /// <param name="arg16">字典参数 16。</param>
        /// <returns>要获取的字典内容字符串。</returns>
        [Preserve]
        public string GetString<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string key, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14,
            T15 arg15, T16 arg16)
        {
            var value = GetRawString(key);
            if (value == null)
            {
                return Utility.Text.Format("<NoKey>{0}", key);
            }

            try
            {
                return Utility.Text.Format(value, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            }
            catch (Exception exception)
            {
                var args = Utility.Text.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
                return Utility.Text.Format("<Error>{0},{1},{2},{3}", key, value, args, exception);
            }
        }

        /// <summary>
        /// 是否存在字典。
        /// </summary>
        /// <param name="key">字典主键。</param>
        /// <returns>是否存在字典。</returns>
        public bool HasRawString(string key)
        {
            GameFrameworkGuard.NotNullOrEmpty(key, nameof(key));
            return _dictionary.ContainsKey(key);
        }

        /// <summary>
        /// 根据字典主键获取字典值。
        /// </summary>
        /// <param name="key">字典主键。</param>
        /// <returns>字典值。</returns>
        [Preserve]
        public string GetRawString(string key)
        {
            GameFrameworkGuard.NotNullOrEmpty(key, nameof(key));
            if (_dictionary.TryGetValue(key, out var value))
            {
                return value;
            }

            return null;
        }

        /// <summary>
        /// 增加字典。
        /// </summary>
        /// <param name="key">字典主键。</param>
        /// <param name="value">字典内容。</param>
        /// <returns>是否增加字典成功。</returns>
        public bool AddRawString(string key, string value)
        {
            GameFrameworkGuard.NotNullOrEmpty(key, nameof(key));
            if (_dictionary.ContainsKey(key))
            {
                return false;
            }

            _dictionary.Add(key, value ?? string.Empty);
            return true;
        }

        /// <summary>
        /// 移除字典。
        /// </summary>
        /// <param name="key">字典主键。</param>
        /// <returns>是否移除字典成功。</returns>
        public bool RemoveRawString(string key)
        {
            GameFrameworkGuard.NotNullOrEmpty(key, nameof(key));
            return _dictionary.Remove(key);
        }

        /// <summary>
        /// 清空所有字典。
        /// </summary>
        public void RemoveAllRawStrings()
        {
            _dictionary.Clear();
        }
    }
}