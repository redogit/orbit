namespace Orbit.Engine;

/// <summary>
/// Base class definition representing a scene or level in a game.
/// </summary>
public abstract class GameScene : GameObjectContainer, IGameScene
{
    /// <inheritdoc />
    protected override void OnGameObjectAdded(GameObject gameObject)
    {
        base.OnGameObjectAdded(gameObject);

        gameObject.CurrentScene = this;
    }

    public GameObject FindCollision(GameObject gameObject)
    {
        return (GameObject)GameObjects.FirstOrDefault(g => !ReferenceEquals(g, gameObject) && g.Bounds.IntersectsWith(gameObject.Bounds));
    }

    void IDrawable.Draw(ICanvas canvas, RectF dirtyRect) => Render(canvas, dirtyRect);
}
