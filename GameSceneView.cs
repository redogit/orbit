namespace Orbit.Engine;

public class GameSceneView : GraphicsView
{
    private IGameScene scene;

    public IGameScene Scene
    {
        get => scene;
        internal set
        {
            scene = value;
            Drawable = value;
        }
    }
}
