using System.Collections;
using UnityEngine;

namespace RPG.SceneManagement
{
    public class Fader : MonoBehaviour
    {
        CanvasGroup canvasGroup;
        Coroutine currentFadeRoutine=null;
        private void Awake() {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        public void FadeOutImmediate()
        {
            canvasGroup.alpha = 1;
        }

         public Coroutine FadeIn(float time)
        {
           return Fade(0,time);
        }
        public Coroutine FadeOut(float time)
        {
           return Fade(1,time);
        }

        private Coroutine Fade(float target , float time)
        {
            if(currentFadeRoutine!=null)
           {
               StopCoroutine(currentFadeRoutine);
           }
           currentFadeRoutine=StartCoroutine(FadeRoutine(target,time));
        return currentFadeRoutine;
        }


        private IEnumerator FadeRoutine(float target ,float time)
        {
             while (!Mathf.Approximately(canvasGroup.alpha,target))
            {
                canvasGroup.alpha = Mathf.MoveTowards(canvasGroup.alpha,target, Time.deltaTime / time);
                yield return null;
            }
        }

       
    }
}