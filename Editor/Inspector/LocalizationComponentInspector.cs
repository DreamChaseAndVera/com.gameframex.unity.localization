//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFrameX.Editor;
using GameFrameX.Localization.Runtime;
using UnityEditor;

namespace GameFrameX.Localization.Editor
{
    [CustomEditor(typeof(LocalizationComponent))]
    internal sealed class LocalizationComponentInspector : GameFrameworkInspector
    {
        private SerializedProperty m_EnableLoadDictionaryUpdateEvent = null;
        private SerializedProperty m_CachedBytesSize = null;
        private SerializedProperty m_EditorLanguage = null;

        private HelperInfo<LocalizationHelperBase> m_LocalizationHelperInfo = new HelperInfo<LocalizationHelperBase>("Localization");

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            serializedObject.Update();

            LocalizationComponent localizationComponent = (LocalizationComponent)target;

            EditorGUI.BeginDisabledGroup(EditorApplication.isPlayingOrWillChangePlaymode);
            {
                EditorGUILayout.PropertyField(m_EditorLanguage);
                EditorGUILayout.HelpBox("Editor language option is only use for localization test in editor mode.", MessageType.Info);
                EditorGUILayout.PropertyField(m_EnableLoadDictionaryUpdateEvent);
                m_LocalizationHelperInfo.Draw();
                EditorGUILayout.PropertyField(m_CachedBytesSize);
            }
            EditorGUI.EndDisabledGroup();

            if (EditorApplication.isPlaying && IsPrefabInHierarchy(localizationComponent.gameObject))
            {
                EditorGUILayout.LabelField("Language", localizationComponent.Language.ToString());
                EditorGUILayout.LabelField("System Language", localizationComponent.SystemLanguage.ToString());
                EditorGUILayout.LabelField("Dictionary Count", localizationComponent.DictionaryCount.ToString());
                // EditorGUILayout.LabelField("Cached Bytes Size", t.CachedBytesSize.ToString());
            }

            serializedObject.ApplyModifiedProperties();

            Repaint();
        }

        protected override void OnCompileComplete()
        {
            base.OnCompileComplete();

            RefreshTypeNames();
        }

        private void OnEnable()
        {
            m_EnableLoadDictionaryUpdateEvent = serializedObject.FindProperty("m_EnableLoadDictionaryUpdateEvent");
            m_CachedBytesSize = serializedObject.FindProperty("m_CachedBytesSize");
            m_EditorLanguage = serializedObject.FindProperty("m_EditorLanguage");
            m_LocalizationHelperInfo.Init(serializedObject);

            RefreshTypeNames();
        }

        private void RefreshTypeNames()
        {
            m_LocalizationHelperInfo.Refresh();
            serializedObject.ApplyModifiedProperties();
        }
    }
}