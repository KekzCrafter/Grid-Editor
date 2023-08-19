using Assets.Scripts.Grid;

namespace Assets.Scripts.Files
{
    public interface IFileHandler
    {
        void Save(GridData gridData);
        GridData Read();
    }
}