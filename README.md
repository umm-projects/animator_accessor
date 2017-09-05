# What?

* `this.Animator()` で参照出来る擬似的なアクセサを提供します

# Why?

* 毎回アクセサを書くのがシンドイので

# Install

```shell
$ npm install github:umm-projects/animator_accessor.git
```

# Usage

```csharp
using UnityEngine;
using AccessorUtility;

public class Hoge : MonoBehaviour, IAnimatorAccessor {

    public void Start() {
        this.Animator().SetTrigger("Fuga");
    }

}
```

1. AccessorUtility.IAnimatorAccessor を実装します
1. 拡張メソッドとして Animator() が提供されます

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

