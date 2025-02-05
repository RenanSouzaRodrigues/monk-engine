namespace MonkEngine.Utils;

public static class Assets {
    public static string GetTextureAssetPath(string assetName) {
        string dirPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Assets\\Textures");
        return dirPath + $"\\{assetName}";
    }
}