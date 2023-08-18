using Praktikum.Scenes.Grid_Editor.Assets.Scripts.Grid;

namespace Praktikum.Scenes.Grid_Editor.Assets.Scripts.Files
{
    public interface IFileHandler
    {
        void Save(GridData gridData);
        GridData Read();
    }
}