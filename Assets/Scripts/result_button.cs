using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class result_button : MonoBehaviour
{
    private List<GameObject> list1= new List<GameObject>();
    private List<GameObject> list2= new List<GameObject>();

    public TextMeshPro text;
    public TextMesh Nupr;

    public void onClick()
    {
        if (Nupr.text.Equals("300"))
        {
            Nupr.text = "180";
        }
        else
        {
            Nupr.text = "300";
        }
        getResult();
    }
    
    void Start()
    {
        list1.Add(GameObject.Find("wood_background"));
        list1.Add(GameObject.Find("rezina_background"));
        list1.Add(GameObject.Find("metall_background"));
        list1.Add(GameObject.Find("10mm_background"));
        list1.Add(GameObject.Find("50mm_background"));
        
        list2.Add(GameObject.Find("5cm_background"));
        list2.Add(GameObject.Find("10cm_background"));
        list2.Add(GameObject.Find("15cm_background"));
        list2.Add(GameObject.Find("20cm_background"));
        list2.Add(GameObject.Find("25cm_background"));
        list2.Add(GameObject.Find("30cm_background"));
        list2.Add(GameObject.Find("40cm_background"));
    }

     public void getResult()
    {
        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i].GetComponent<rotate_up>().click)
            {
                setText(i);
                return;
            }
        }
        
        for (int i = 0; i < list2.Count; i++)
        {
            if (list2[i].GetComponent<rotate_left>().click)
            {
                setText(i + 5);
                return;
            }
        }
    }

     void setText(int i)
    {
        if (Nupr.text.Equals("300"))
        {
            switch (i)
            {
                case 0:
                    text.text = "Результат: 80\nРасстояние: 5 см\nЭкран: Полистирол\nМощность:";
                    break;
                case 1:
                    text.text = "Результат: 40\nРасстояние: 5 см\nЭкран: Резина\nМощность:";
                    break;
                case 2:
                    text.text = "Результат: 10\nРасстояние: 5 см\nЭкран: Алюминий\nМощность:";
                    break;
                case 3:
                    text.text = "Результат: 15\nРасстояние: 5 см\nЭкран: Сетка 10мм\nМощность:";
                    break;
                case 4:
                    text.text = "Результат: 50\nРасстояние: 5 см\nЭкран: Сетка 50мм\nМощность:";
                    break;
                case 5:
                    text.text = "Результат: 120\nРасстояние: 5 см\nЭкран: none\nМощность:";
                    break;
                case 6:
                    text.text = "Результат: 100\nРасстояние: 10 см\nЭкран: none\nМощность:";
                    break;
                case 7:
                    text.text = "Результат: 80\nРасстояние: 15 см\nЭкран: none\nМощность:";
                    break;
                case 8:
                    text.text = "Результат: 60\nРасстояние: 20 см\nЭкран: none\nМощность:";
                    break;
                case 9:
                    text.text = "Результат: 80\nРасстояние: 25 см\nЭкран: none\nМощность:";
                    break;
                case 10:
                    text.text = "Результат: 100\nРасстояние: 30 см\nЭкран: none\nМощность:";
                    break;
                case 11:
                    text.text = "Результат: 120\nРасстояние: 40 см\nЭкран: none\nМощность:";
                    break;
                default:
                    text.text = "Ошибка";
                    break;
            }
        }
        else
        {
            switch (i)
            {
                case 0:
                    text.text = "Результат: 40\nРасстояние: 5 см\nЭкран: Полистирол\nМощность:";
                    break;
                case 1:
                    text.text = "Результат: 20\nРасстояние: 5 см\nЭкран: Резина\nМощность:";
                    break;
                case 2:
                    text.text = "Результат: 5\nРасстояние: 5 см\nЭкран: Алюминий\nМощность:";
                    break;
                case 3:
                    text.text = "Результат: 25\nРасстояние: 5 см\nЭкран: Сетка 10мм\nМощность:";
                    break;
                case 4:
                    text.text = "Результат: 50\nРасстояние: 5 см\nЭкран: Сетка 50мм\nМощность:";
                    break;
                case 5:
                    text.text = "Результат: 90\nРасстояние: 5 см\nЭкран: none\nМощность:";
                    break;
                case 6:
                    text.text = "Результат: 80\nРасстояние: 10 см\nЭкран: none\nМощность:";
                    break;
                case 7:
                    text.text = "Результат: 70\nРасстояние: 15 см\nЭкран: none\nМощность:";
                    break;
                case 8:
                    text.text = "Результат: 60\nРасстояние: 20 см\nЭкран: none\nМощность:";
                    break;
                case 9:
                    text.text = "Результат: 70\nРасстояние: 25 см\nЭкран: none\nМощность:";
                    break;
                case 10:
                    text.text = "Результат: 80\nРасстояние: 30 см\nЭкран: none\nМощность:";
                    break;
                case 11:
                    text.text = "Результат: 90\nРасстояние: 40 см\nЭкран: none\nМощность:";
                    break;
                default:
                    text.text = "Ошибка";
                    break;
            }
        }
    }
}
