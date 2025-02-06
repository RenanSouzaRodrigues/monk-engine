using Raylib_cs;

namespace MonkEngine.Core;

public class AssetHandler {
    private string GetAssetPath() {
        return Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
    }

    public Music LoadMusic(string folder, string fileName) {
        string dirPath = Path.Combine(GetAssetPath(), "Assets");
        string file = Path.Combine(dirPath, folder, fileName);
        return Raylib.LoadMusicStream(file);
    }

    public Texture2D LoadSprite(string folder, string fileName) {
        string dirPath = Path.Combine(GetAssetPath(), "Assets");
        string file = Path.Combine(dirPath, folder, fileName);
        return Raylib.LoadTexture(file);
    }
}