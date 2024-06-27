using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneManager : BYSingletonMono<LoadSceneManager>
{
    public GameObject ui_object;
    public Slider slider_progress;
    public Text progress_lb;
    public float time_delay = 0.1f;
    public float width = 2560;
    public void LoadSceneByName(string scene_name, Action callback)
    {
        StartCoroutine(LoadSceneByNameProgress(scene_name, callback));
    }
    IEnumerator LoadSceneByNameProgress(string scene_name, Action callback)
    {
        ui_object.SetActive(true);
        AsyncOperation async = SceneManager.LoadSceneAsync(scene_name, LoadSceneMode.Single);
        WaitForSeconds wait_s = new WaitForSeconds(time_delay);
        int count = 0;
        while (count < 101)
        {
            yield return wait_s;
            count++;
            progress_lb.text = /*"<color=#00FFFF>" +*/ count.ToString() + "%" /*+ "</color>"*/;
            slider_progress.value = count;
        }
        while (!async.isDone)
        {
            yield return wait_s;
            progress_lb.text = /*"<color=#00FFFF>" +*/ ((int)(async.progress * 100)).ToString() + "%" /*+ "</color>"*/;
            slider_progress.value = count;
        }
        callback?.Invoke();
        ui_object.SetActive(false);
    }
    public void LoadSceneByIndex(int scene_index, Action callback)
    {
        StartCoroutine(LoadSceneByIndexProgress(scene_index, callback));
    }
    IEnumerator LoadSceneByIndexProgress(int scene_index, Action callback)
    {
        Debug.Log("Scene index in load scene: " + scene_index);
        ui_object.SetActive(true);
        AsyncOperation async = SceneManager.LoadSceneAsync(scene_index, LoadSceneMode.Single);
        WaitForSeconds wait_s = new WaitForSeconds(time_delay);
        int count = 0;
        while (count < 101)
        {
            yield return wait_s;
            count++;
            progress_lb.text = /*"<color=#00FFFF>" +*/ count.ToString() + "%" /*+ "</color>"*/;
            // image_progress.fillAmount = (float)count / 100f;
            slider_progress.value = count;
        }
        while (!async.isDone)
        {
            yield return wait_s;
            progress_lb.text = /*"<color=#00FFFF>" +*/ ((int)(async.progress * 100)).ToString() + "%" /*+ "</color>"*/;
            //image_progress.fillAmount = async.progress;
            slider_progress.value = count;
        }
        callback?.Invoke();
        ui_object.SetActive(false);
    }
}
