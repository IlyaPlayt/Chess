using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Team : MonoBehaviour
    {
        [SerializeField] private FigurePositions figurePositions;
        [SerializeField] private FigurePrototype[] figures;
        [SerializeField] private Material figureMaterial;

        private void Start()
        {
            SetDefault();
        }

        private void SetDefault()
        {
            GameObject obj;
            Vector3 position = transform.position;
            foreach (var figure in figures)
            {
                var figPos = figurePositions.FigurePosition[figure.FigureId];
                if (figure.FigureName != "Pawn" && figure.FigureName != "Queen" && figure.FigureName != "King")
                {
                   
                    obj = Instantiate(figure.Prefab, this.transform);
                    obj.transform.position = new Vector3(figPos.x, 0,
                        transform.position.z + figPos.z);
                    obj.GetComponent<MeshRenderer>().material = figureMaterial;
                    obj = Instantiate(figure.Prefab, this.transform);
                    obj.transform.position = new Vector3(7 - figPos.x, 0,
                        position.z + figPos.z);
                    obj.GetComponent<MeshRenderer>().material = figureMaterial;
                }
                else if (figure.FigureName == "Pawn")
                {
                    for (int i = 0; i < 8; i++)
                    {
                        obj = Instantiate(figure.Prefab, this.transform);
                        obj.transform.position = new Vector3(figPos.x+i, 0,
                            transform.position.z + figPos.z);
                        obj.GetComponent<MeshRenderer>().material = figureMaterial;
                    }
                }
                else
                {
                    obj = Instantiate(figure.Prefab, this.transform);
                    obj.transform.position = new Vector3(figPos.x, 0,
                        transform.position.z + figPos.z);
                    obj.GetComponent<MeshRenderer>().material = figureMaterial;
                }
            }
        }
    }
}