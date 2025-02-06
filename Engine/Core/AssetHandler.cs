using Raylib_cs;

namespace MonkEngine.Core;

public class AssetHandler() {
    private static string GetAssetPath() {
        return Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
    }

    public static Music GetMusicAsset(string soundPathAndName) {
        string assetDirPath = GetAssetPath();
        string dirPath = Path.Combine(GetAssetPath(), "Assets");
        string file = dirPath + $"\\{soundPathAndName}"; 
        return Raylib.LoadMusicStream(file);
    }
}