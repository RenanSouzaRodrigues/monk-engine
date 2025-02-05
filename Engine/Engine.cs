using Raylib_cs;
using MonkEngine.Entities;

namespace MonkEngine;

public class Engine {
    private readonly string _gameName;
    private readonly List<IEntity> _gameEntities = [];
    private float _deltaTime;
    private bool _debug = false;

    public Engine(string gameName = "Monk Engine") {
        _gameName = gameName;
    }

    public void AddNewGameEntity(IEntity newEntity) {
        _gameEntities.Add(newEntity);
    }

    public void EnableDebug() => _debug = true;

    public void StartEngine() {
        Raylib.SetConfigFlags(ConfigFlags.Msaa4xHint);
        Raylib.InitWindow(1920, 1080, _gameName);

        _gameEntities.ForEach(entity => entity.Init());

        while (!Raylib.WindowShouldClose()) {
            _deltaTime = Raylib.GetFrameTime();
            _gameEntities.ForEach(entity => entity.Update(_deltaTime));

            Raylib.BeginDrawing();
            
            Raylib.ClearBackground(new Color(12, 19, 23, 255));
            _gameEntities.ForEach(entity => entity.Draw());

            if (_debug) {
                Raylib.DrawFPS(10, 10);
                Raylib.DrawText("Current Monitor: " + Raylib.GetCurrentMonitor().ToString(), 10, 50, 20, Color.Red);
            }

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
        _gameEntities.ForEach(entity => entity.Destroy());
    }
}