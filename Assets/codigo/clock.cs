using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class clock : MonoBehaviour {

	// Use this for initialization

	DateTime datestime;
	public Text horas, minutos, segundos;
//	public Text timer;
	public Text año, mes, dia;

	void Start ()
	{
		
	}

	void Update()
	{
		datestime = DateTime.Now;

		horas.text = datestime.Hour.ToString("00");
		minutos.text = datestime.Minute.ToString("00");
		segundos.text = datestime.Second.ToString("00");


	/*	if((datestime.Hour > 12) && ( datestime.Hour < 24)) 
		{
			timer.text = "PM";
		}

		if((datestime.Hour < 12) && (datestime.Hour >- 0))
		{
			timer.text = "AM";
		}*/

		año.text = datestime.Year.ToString("0000");
		mes.text = datestime.Month.ToString("00");
		dia.text = datestime.Day.ToString ("00");


	}
		


		

}
