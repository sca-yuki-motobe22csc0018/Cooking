using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDif : MonoBehaviour
{
    [SerializeField] public GameObject[] Dif;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; ++i)
        {
            Dif[i].SetActive(false);
        }
        if (DifficultySelect.dif == 0)
        {
            Dif[0].SetActive(true);
        }
        else if (DifficultySelect.dif == 1)
        {
            Dif[1].SetActive(true);
        }
        else if (DifficultySelect.dif == 2)
        {
            Dif[2].SetActive(true);
        }
        else if (DifficultySelect.dif == 3)
        {
            Dif[3].SetActive(true);
        }
        else if (DifficultySelect.dif == 4)
        {
            Dif[4].SetActive(true);
        }
        else if (DifficultySelect.dif == 5)
        {
            Dif[5].SetActive(true);
        }
        else if (DifficultySelect.dif == 6)
        {
            Dif[6].SetActive(true);
        }
    }
}
