using UnityEngine;

namespace AccessorUtility {

    /// <summary>
    /// DI っぽく MonoBehaviour に Animator() メソッドを提供するためのインタフェース
    /// </summary>
    public interface IAnimatorAccessor {
    }

    /// <summary>
    /// IAnimatorAccessor の拡張クラス
    /// </summary>
    public static class AnimatorAccessorExtension {

        /// <summary>
        /// IAnimatorAccessor を実装しているクラスに `.Animator()` として Getter を提供する
        /// </summary>
        /// <param name="self">IAnimatorAccessor のインスタンス</param>
        /// <returns>Animator のインスタンス</returns>
        public static Animator Animator(this IAnimatorAccessor self) {
            // ReSharper disable once SuspiciousTypeConversion.Global
            MonoBehaviour monoBehaviour = self as MonoBehaviour;
            if (monoBehaviour == null) {
                return null;
            }
            // 未セットの場合に、GetComponent した結果をキャッシュさせる
            if (!monoBehaviour.PropertyExists<Animator>()) {
                Animator animator = monoBehaviour.gameObject.GetComponent<Animator>();
                monoBehaviour.PropertySet(animator);
            }
            return monoBehaviour.PropertyGet<Animator>();
        }

    }
}