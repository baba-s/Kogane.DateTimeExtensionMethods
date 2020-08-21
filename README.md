# UniDateTimeExtensionMethods

DateTime 型の拡張メソッド

## 使用例

```cs
using Kogane;
using System;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        var now = DateTime.Now;

        Debug.Log( now.ToPattern() );               // yyyy/MM/dd HH:mm:ss
        Debug.Log( now.ToShortDatePattern() );      // yyyy/MM/dd
        Debug.Log( now.ToLongDatePattern() );       // yyyy年M月d日
        Debug.Log( now.ToFullDateTimePattern() );   // yyyy年M月d日 HH:mm:ss
        Debug.Log( now.ToMiddleDateTimePattern() ); // MM/dd HH:mm
        Debug.Log( now.ToShortTimePattern() );      // HH:mm
        Debug.Log( now.ToLongTimePattern() );       // HH:mm:ss
    }
}
```
