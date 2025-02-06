using Raylib_cs;
using MonkEngine.Core;
using MonkEngine.Scene;

namespace MonkEngine;

public class Engine {
    // Engine core handlers. -Renan
    public static readonly AssetHandler Assets = new();
    public static readonly AudioHandler Audio = new();

    // I should be using a different struct to handle the scenes but for now, this is ok. -Renan
    private readonly List<IScene> _gameScenes = [];

    private readonly string _gameName;
    private float _deltaTime = 0;
    private bool _debug = false;

    public Engine(string gameName) => _gameName = gameName;
    public void ToggleDebugMode() => _debug = !_debug;

    public void StartEngine() {
        // this is a place holder for now. -Renan
        Raylib.InitWindow(1920, 1080, _gameName);

        // Initialize the game scenes
        _gameScenes.ForEach(scene => scene.InitEntities());

        while (!Raylib.WindowShouldClose()) {
            // Updated the game delta time every single tick
            _deltaTime = Raylib.GetFrameTime();
            
            _gameEntities.ForEach(entity => entity.Update(_deltaTime));


            Raylib.EndDrawing();
        }

        Raylib.CloseAudioDevice();
        Raylib.CloseWindow();
        _gameEntities.ForEach(entity => entity.Destroy());
    }
}