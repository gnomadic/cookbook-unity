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

public static class VectorExtension {

	/// <summary>
	/// Find the centerpoint between this vector and another.
	/// </summary>
	/// <param name="myVector">The vector.</param>
	/// <param name="target">The vector to find the centerpoint between.</param>
	public static Vector3 getMidPoint(this Vector3 myVector, Vector3 target){
		return new Vector3 ((myVector.x + target.x) / 2, (myVector.y + target.y) / 2, (myVector.z + target.z) / 2);
	}

	/// <summary>
	/// Set the X value of this vector.
	/// </summary>
	/// <param name="myVector">The vector.</param>
	/// <param name="x">The value to set X to.</param>
	public static Vector3 setX(this Vector3 myVector, float x){
		myVector.x = x;
		return myVector;
	}

	/// <summary>
	/// Set the Y value of this vector.
	/// </summary>
	/// <param name="myVector">The vector.</param>
	/// <param name="y">The value to set Y to.</param>
	public static Vector3 setY(this Vector3 myVector, float y){
		myVector.y = y;
		return myVector;
	}

	/// <summary>
	/// Set the Z value of this vector.
	/// </summary>
	/// <param name="myVector">The vector.</param>
	/// <param name="z">The value to set Z to.</param>
	public static Vector3 setZ(this Vector3 myVector, float z){
		myVector.z = z;
		return myVector;
	}
}
