using MonkEngine;
using MonkEngine.Entities;
using Raylib_cs;

public class Game {
    public static void Main() {
        Engine engine = new();
        engine.ToggleDebugMode();
        engine.StartEngine();
    }
}
