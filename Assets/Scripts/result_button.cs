using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class result_button : MonoBehaviour
{
    //private GameObject arrow;
    private List<GameObject> list1= new List<GameObject>();
    private List<GameObject> list2= new List<GameObject>();

    public TextMeshPro text;

    
    void Start()
    {
        //arrow = GameObject.Find("arrow");
        
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
        switch (i)
        {
          case 0: text.text = "Результат: 80\nРасстояние: 5 см\nЭкран: Полистирол";
              //arrow.GetComponent<rotate_arrow>().i = 80;
              break;
          case 1: text.text = "Результат: 40\nРасстояние: 5 см\nЭкран: Резина";
              //arrow.GetComponent<rotate_arrow>().i = 40;
              break;
          case 2: text.text = "Результат: 10\nРасстояние: 5 см\nЭкран: Алюминий";
              //arrow.GetComponent<rotate_arrow>().i = 10;
              break;
          case 3: text.text = "Результат: 15\nРасстояние: 5 см\nЭкран: Сетка 10мм";
              //arrow.GetComponent<rotate_arrow>().i = 15;
              break;
          case 4: text.text = "Результат: 50\nРасстояние: 5 см\nЭкран: Сетка 50мм";
              //arrow.GetComponent<rotate_arrow>().i = 50;
              break;
          case 5: text.text = "Результат: 120\nРасстояние: 5 см\nЭкран: none";
              //arrow.GetComponent<rotate_arrow>().i = 120;
              break;
          case 6: text.text = "Результат: 100\nРасстояние: 10 см\nЭкран: none";
              //arrow.GetComponent<rotate_arrow>().i = 100;
              break;
          case 7: text.text = "Результат: 80\nРасстояние: 15 см\nЭкран: none";
              //arrow.GetComponent<rotate_arrow>().i = 80;
              break;
          case 8: text.text = "Результат: 60\nРасстояние: 20 см\nЭкран: none";
              //arrow.GetComponent<rotate_arrow>().i = 60;
              break;
          case 9: text.text = "Результат: 80\nРасстояние: 25 см\nЭкран: none";
              //arrow.GetComponent<rotate_arrow>().i = 80;
              break;
          case 10: text.text = "Результат: 100\nРасстояние: 30 см\nЭкран: none";
              //arrow.GetComponent<rotate_arrow>().i = 100;
              break;
          case 11: text.text = "Результат: 120\nРасстояние: 40 см\nЭкран: none";
              //arrow.GetComponent<rotate_arrow>().i = 120;
              break;
          default: text.text = "Ошибка";
              break;
        }
    }
}
