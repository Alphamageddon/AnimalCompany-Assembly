using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using UnityEngine;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    private struct MonoScriptData
    {
        public byte[] FilePathsData;
        public byte[] TypesData;
        public int TotalTypes;
        public int TotalFiles;
        public bool IsEditorOnly;
    }

    public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
    {
    }

    private static MonoScriptData Get()
    {
        MonoScriptData result = default(MonoScriptData);
        
        byte[] filePathsData = new byte[12588];
        RuntimeHelpers.InitializeArray(filePathsData, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
        
        byte[] typesData = new byte[8456];
        RuntimeHelpers.InitializeArray(typesData, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
        
        result.FilePathsData = filePathsData;
        result.TypesData = typesData;
        result.TotalTypes = 0;
        result.TotalFiles = 0;
        result.IsEditorOnly = false;
        
        return result;
    }
}