using System.Reflection;
#if WINDOWS
using Microsoft.Maui.Graphics.Win2D;
using IImage = Microsoft.Maui.Graphics.IImage;
#else
using Microsoft.Maui.Graphics.Platform;
#endif

namespace Orbit.Engine;

/// <summary>
/// Base class definition representing an object in a game.
/// </summary>
public abstract class GameObject : GameObjectContainer, IGameObject, IDrawable
{
    public GameScene CurrentScene { get; internal set; } // TODO: weak reference?

    public virtual bool IsCollisionDetectionEnabled { get; }

    public RectF Bounds { get; set; }
    protected string ImageName => GetType().Name + ".jpg";
    protected IImage LoadedImage { get; set; } = null;
    protected IImage LoadImage(string imageName) => LoadImageInternal(imageName);

    IImage LoadImageInternal(string imageName)
    {
        var assembly = GetType().GetTypeInfo().Assembly;

        Stream stream = assembly.GetManifestResourceStream(imageName);
#if WINDOWS
        return new W2DImageLoadingService().FromStream(stream);
#else
        return PlatformImage.FromStream(stream);
#endif
    }

    void IDrawable.Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.SaveState();
        canvas.ResetState();

        Render(canvas, dirtyRect);

        canvas.RestoreState();
    }
}
