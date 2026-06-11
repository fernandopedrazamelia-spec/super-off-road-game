using UnityEngine;

namespace SuperOffRoad.Terrain
{
    public class TerrainType : MonoBehaviour
    {
        public enum Type { Road, Mud, Sand, Stone }
        public Type terrainType = Type.Road;
        
        [SerializeField] private Color terrainColor = Color.gray;

        private void Start()
        {
            GetComponent<SpriteRenderer>().color = terrainColor;
        }
    }
}
