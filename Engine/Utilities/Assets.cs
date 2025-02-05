namespace MonkEngine.Utils;

public static class Assets {
    private static string GetAssetPath() {
        return Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
    }

    public static string GetTextureAssetPath(string assetName) {
        string dirPath = Path.Combine(GetAssetPath(), "Assets\\Textures");
        return dirPath + $"\\{assetName}";
    }

    public static string GetSoundAssetPath(string assetName) {
        string dirPath = Path.Combine(GetAssetPath(), "Assets\\Sounds");
        return dirPath + $"\\{assetName}";
    }
}