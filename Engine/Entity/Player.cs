using Raylib_cs;
using MonkEngine.Components;
using System.Numerics;
using MonkEngine.Utils;

namespace MonkEngine.Entities;
public class Player : IEntity {
    private SpriteRenderer _spriteRenderer;

    private Texture2D _texture;

    public Player() {
        _spriteRenderer = new();
    }

    public void Init() {
        _texture = Raylib.LoadTexture(Assets.GetTextureAssetPath("rogues.png"));
    }

    public void Update(float deltaTime) {
                        
    }

    public void Draw() {
        Rectangle source = new(1920/2, 1080/2, new Vector2(32, 32));
        Rectangle destination = new(0, 32, new Vector2(32 ,32));
        Raylib.DrawTexture(_texture, 400, 400, Color.White);
    }

    public void Destroy() {
        Raylib.UnloadTexture(_texture);
    }
}