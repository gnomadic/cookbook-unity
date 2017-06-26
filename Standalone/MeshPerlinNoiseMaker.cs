/*
  Copyright 2017 Edward Fleming III

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

[RequireComponent (typeof (MeshFilter))]
public class MeshPerlinNoiseMaker : MonoBehaviour {

  public float power = 3.0f;
  public float scale = 1.0f;
  public float offset = 0.5f;

  private Vector2 IV = new Vector2(0f, 0f);

  void Start () {
    MakeSomeNoise ();
  }

  void Update () {
    //NOTE probably don't want to regenerate on spacebar, but this helps figure out variable values
    if (Input.GetKeyDown (KeyCode.Space)) {
      MakeSomeNoise();
    }
  }

  void MakeSomeNoise() {
    IV = new Vector2(Random.Range (0.0f, 100.0f), Random.Range (0.0f, 100.0f));
    float scratchX;
    float scratchY;

    MeshFilter mf = GetComponent<MeshFilter>();
    Vector3[] vertices = mf.mesh.vertices;
    int vertCount = vertices.Length;
    for (int i = 0; i < vertCount; i++) {
      scratchX = IV.x + vertices[i].x  * scale;
      scratchY = IV.y + vertices[i].z  * scale;
      vertices[i].y = (Mathf.PerlinNoise (scratchX, scratchY) - offset) * power;
    }
    mf.mesh.vertices = vertices;

    mf.mesh.RecalculateBounds();
    mf.mesh.RecalculateNormals();
  }
}
