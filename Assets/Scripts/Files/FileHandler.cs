using System;
using System.IO;
using Praktikum.Scenes.Grid_Editor.Assets.Scripts.Grid;
using UnityEngine;

namespace Praktikum.Scenes.Grid_Editor.Assets.Scripts.Files
{
    public class FileHandler : IFileHandler
    {
        public void Save(GridData gridData)
        {
            CreateFolder();

            var jsonString = JsonUtility.ToJson(gridData.ReplaceGridObjects(), true);
            File.WriteAllText(GetFolderPath() + "GridObjectPositions.json", jsonString);
        }

        public GridData Read()
        {
            var filePath = GetFolderPath() + "GridObjectPositions.json";
            if (!File.Exists(filePath))
            {
                return null;
            }

            var jsonString = File.ReadAllText(filePath);
            return JsonUtility.FromJson<GridData>(jsonString);
        }        
        
        private static void CreateFolder()
        {
            if (Directory.Exists(GetFolderPath()))
            {
                return;
            }
        
            Directory.CreateDirectory(GetFolderPath());
        }
    
        private static string GetFolderPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Grid Editor\\";
        }
    }
}