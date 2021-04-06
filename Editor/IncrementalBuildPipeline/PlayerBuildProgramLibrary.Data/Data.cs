// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

namespace PlayerBuildProgramLibrary.Data
{
    public class Plugin
    {
        public string AssetPath;
        public string DestinationPath;

        public override string ToString()
        {
            return $"'{AssetPath} -> '{DestinationPath}'";
        }
    }

    public class PluginsData
    {
        public Plugin[] Plugins = new Plugin[0];
    }

    public class PlayerBuildConfig
    {
        public string DestinationPath;
        public string StagingArea;
        public string DataFolder;
        public string CompanyName;
        public string ProductName;
        public string PlayerPackage;
        public string ApplicationIdentifier;
        public string Architecture;
        public bool UseIl2Cpp;
        public bool InstallIntoBuildsFolder;
        public bool GenerateIdeProject;
        public bool Development;
        public Services Services;
    }

    public class BuiltFilesOutput
    {
        public string[] Files = new string[0];
    }

    public class LinkerConfig
    {
        public string[] LinkXmlFiles = new string[0];
        public string[] AssembliesToProcess = new string[0];
        public string[] SearchDirectories = new string[0];
        public string EditorToLinkerData;
        public string Runtime;
        public string Profile;
        public string Ruleset;
        public string ModulesAssetPath;
        public string[] AdditionalArgs = new string[0];
        public bool AllowDebugging;
        public bool PerformEngineStripping;
    }

    public class Il2CppConfig
    {
        public bool EnableDeepProfilingSupport;
        public string Profile;

        public string ConfigurationName;
        public bool GcWBarrierValidation;
        public bool GcIncremental;

        public string[] AdditionalCppFiles = new string[0];
        public string[] AdditionalArgs = new string[0];
        public string ExtraTypes;
        public bool CreateSymbolFiles;
    }

    public class Services
    {
        public bool EnableUnityConnect;
        public bool EnablePerformanceReporting;
        public bool EnableAnalytics;
        public bool EnableCrashReporting;
    }
}