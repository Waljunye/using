using System;
using UnityEngine;

namespace DisposableAnimation
{
    public class AnimationHandler: IDisposable
    {
        private Animator _animator;

        public AnimationHandler(Animator animator)
        {
            _animator = animator;
            _animator.SetBool("IsAnimating", true);
        }

        public void Dispose()
        {
            _animator.SetBool("IsAnimating", false);
            GC.SuppressFinalize(this);
        }

        ~AnimationHandler()
        {
            Dispose();
        }
    }
}