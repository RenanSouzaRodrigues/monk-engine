using MonkEngine.Core;
using MonkEngine.ECS;
using Raylib_cs;

namespace MonkEngine.ECS.NativeComponents;

public class SpriteRendererComponent : IComponent {
    public Texture2D _spriteTexture; 
    
    public SpriteRendererComponent() {
        _spriteTexture = Engine.Assets.LoadSprite("Textures", "rogues.png");
    }

    public void DrawSprite() {
        
    }
}