using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

[CreateAssetMenu]
public class FigurePrototype : ScriptableObject
{
   
    [SerializeField] private string figureName;
    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector3 move;
    [SerializeField] private bool fixedDistance;
    [SerializeField] private int figureId;


    public string FigureName => figureName;
    public Vector3 Move => move;
    public bool MoveDistance => fixedDistance;
    public GameObject Prefab => prefab;
    public int FigureId => figureId;
}