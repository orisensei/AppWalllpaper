using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicplayer : MonoBehaviour {

	// Use this for initialization

        public AudioClip[] clips;

        private int index = 0;
        private AudioSource Player;
        private Text titulo, tiempo;

	void Start () {
        Player = GetComponent<AudioSource>();
        Player.clip = clips[index];
        titulo = transform.Find("nombre").gameObject.GetComponent<Text>();
        titulo.text = Player.clip.name;
        tiempo = transform.Find("tiempo").gameObject.GetComponent<Text>();
    }

   public void Play()
    {

        if (CheckNullsong())
        {
            return;
        }
        if (!Player.isPlaying)
        {
            Player.Play();



        }
        else
        {
            Player.Pause();
        }
        
    }

    public void Stop()
    {
        Player.Stop();
    }

    public void Next()
    {
        Player.clip = clips[++index % clips.Length];
        if (CheckNullsong())
        {
            return;
        }
        Player.Play();
        titulo.text = Player.clip.name;
    }

    public void Prev()
    {
        if (--index < 0) index = clips.Length - 1;
        Player.clip = clips[index % clips.Length];
        if (CheckNullsong())
        {
            return;
        }
        Player.Play();

        titulo.text = Player.clip.name;
    }

    // Update is called once per frame
    void Update () {
        int minutos = (int) Player.time / 60;
        int segundos = (int)Player.time % 60;
    //    tiempo.text = minutos.ToString("00") + ":" + segundos.ToString("00");


	}

    bool CheckNullsong()
    {
        if (Player.clip == null)
        {
            Debug.Log("no hay cancion");
            titulo.text = "Pista no encontrada";
            return true;
        }
            return false;
    }
}
