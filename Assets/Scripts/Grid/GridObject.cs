using System;

namespace Praktikum.Scenes.Grid_Editor.Assets.Scripts.Grid
{
    
    [Serializable]
    public class GridObject
    {
        public int id;
        public GridObjectType type;
        
        public float positionX;
        public float positionY;
        public float positionZ;

        public GridObject Construct(int id, GridObjectType gridObjectType)
        {
            this.id = id;
            type = gridObjectType;

            return this;
        }
        
        public GridObject SetId(int id)
        {
            this.id = id;

            return this;
        }

        public GridObject SetPosition(float posX, float posY, float posZ)
        {
            positionX = posX;
            positionY = posY;
            positionZ = posZ;
            
            return this;
        }
    }
}