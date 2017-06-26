/*
  Copyright 2014 Edward Fleming III
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at
       http://www.apache.org/licenses/LICENSE-2.0
   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class TransformExtension {

    /// <summary>
    /// Destory all children of this Transfrom.
    /// </summary>
    /// <param name="transform">The transform.</param>
    public static Transform DestroyAllChildren(this Transform transform){
        foreach (Transform child in transform) {
            GameObject.Destroy(child.gameObject);
        }
        return transform;
    }

     /// <summary>
    /// Destory all children of this Transfrom after a delay.
    /// </summary>
    /// <param name="transform">The transform.</param>
    /// <param name="delay">How long to wait, in seconds.</param>
    public static Transform DestroyAllChildren(this Transform transform, float delay){
        foreach (Transform child in transform) {
            GameObject.Destroy(child.gameObject, delay);
        }
        return transform;
    }
}
