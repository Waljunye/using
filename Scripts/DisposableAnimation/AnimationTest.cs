using System.Collections;
using UnityEngine;

namespace DisposableAnimation
{
    public class AnimationTest: MonoBehaviour
    {
        public Animator animator;

        private void Update()
        {
        }
        
        private IEnumerator OnMouseDown()
        {
            Debug.Log(nameof(OnMouseDown));
            
            using (var animHandler = new AnimationHandler(animator))
            {
                yield return new WaitForSeconds(2);
            }
            Debug.Log("Анимация автоматически остановлена после завершения блока using.");

        }
    }
}