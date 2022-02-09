using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class FigurePositions : ScriptableObject
    {
        [SerializeField] private List<Vector3> figurePosition;
        
        public List<Vector3> FigurePosition => figurePosition;
    }
}