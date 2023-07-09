using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour {
	public int Cena; // установим цену нашей монеты (т.е. какое количество монет будет прибавляться при сборе определенной монеты)

    private void OnTriggerEnter(Collider other)
    {
        PlayerController.money += Cena; // добавляем монеты в указанную ссылку
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().TextMoney.text = PlayerController.money.ToString();
        Debug.Log("1 Egg");// вывод количеста монет на экран
        Destroy(gameObject);
    }
}

