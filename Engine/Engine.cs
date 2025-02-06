using MonkEngine.Core;
using MonkEngine.Scene;

namespace MonkEngine;

public class Engine {
    // Engine core handlers
    public static readonly AssetHandler Assets = new();
    public static readonly WindowHandler Window = new();
    public static readonly AudioHandler Audio = new();
    public static readonly DebugHandler Debugger = new();

    // I should be using a different struct to handle the scenes but for now, this is ok
    private readonly List<IScene> _gameScenes = new();
    private float _deltaTime = 0;
    private bool _debug = false;
    
    public void StartEngine() {
        Window.Create("Monk Engine");

        // Initialize the game scenes
        _gameScenes.ForEach(scene => scene.InitEntities());

        while (!Window.QuitApplication()) {
            // Updated the game delta time every single tick
            _deltaTime = Window.GetDeltaTime();
            
            // Here goes all the logic calls
            _gameScenes.ForEach(scenes => scenes.UpdateSceneEntities(_deltaTime));
            
            Window.BeginDraw();
            
            // Here goes all the draw calls
            _gameScenes.ForEach(scenes => scenes.DrawSceneEntities());

            if (_debug) {
                Debugger.ShowFPS();
            }

            Window.EndDraw();
        }

        Audio.Destroy();
        Window.Destroy();
        _gameScenes.ForEach(scene => scene.DestroyEntities());
    }

    public void ToggleDebugMode() => _debug = !_debug;
    public void AddGameScene(IScene gameScene) => _gameScenes.Add(gameScene);
}