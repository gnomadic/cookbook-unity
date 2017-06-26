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

public static class ListExtension {

	private static System.Random myRandom = null;

	private static System.Random getRandom(){
		if (myRandom == null) {
			myRandom = new System.Random ();
		}
		return myRandom;
	}

	/// <summary>
	/// Get a random element from the list.
	/// </summary>
	/// <param name="myList">The list.</param>
	public static T getRandom<T>(this List<T> myList){
		return myList[getRandom().Next (0, myList.Count)];
	}

	/// <summary>
	/// Get a random element from a half of the list.
	/// </summary>
	/// <param name="myList">The list.</param>
	/// <param name="firstHalf">Boolean indicating first half or second half.</param>
	public static T getRandomHalf<T>(this List<T> myList, bool firstHalf){
		if (firstHalf) {
			return myList [getRandom().Next (0, myList.Count / 2)];
		}
		return myList [getRandom ().Next (myList.Count / 2, myList.Count)];
	}

	/// <summary>
	/// Get a random element ignoring a provided subset.
	/// </summary>
	/// <param name="myList">The list.</param>
	/// <param name="exclude">HashSet containing index of elements to exclude.</param>
	public static T getRandom<T>(this List<T> myList, HashSet<int> exclude){

		var range = Enumerable.Range(0, myList.Count).Where(i => !exclude.Contains(i));
		int index = getRandom().Next(0, myList.Count - exclude.Count);
		return myList[range.ElementAt(index)];
	}

	/// <summary>
	/// Get a random element ignoring a provided subset.
	/// </summary>
	/// <param name="myList">The list.</param>
	/// <param name="exclude">HashSet containing elements to exclude.</param>
	public static T getRandom<T>(this List<T> myList, HashSet<T> exclude){
		var tmp = myList.Where (m => !exclude.Contains(m)).ToList ();
		return tmp[getRandom().Next (0, tmp.Count)];
	}

	/// <summary>
	/// Add the item to the end of the list
	/// </summary>
	/// <param name="myList">My list.</param>
	/// <param name="toadd">The item to add.</param>
	public static void Push<T>(this List<T> myList, T toadd){
		myList.Add (toadd);
	}

	/// <summary>
	/// Remove and return the first item.
	/// </summary>
	/// <param name="myList">My list.</param>
	public static T Pop<T>(this List<T> myList){
		if (myList.Count == 0) {
			return default(T);
		}
		T ret = myList [0];
		myList.RemoveAt (0);
		return ret;
	}
	/// <summary>
	/// View the first item.
	/// </summary>
	/// <param name="myList">My list.</param>
	public static T Peek<T>(this List<T> myList){
		if (myList.Count == 0) {
			return default(T);
		}
		return myList [0];
	}

	/// <summary>
	/// Randomly sort the list.
	/// </summary>
	/// <param name="myList">The list.</param>
	public static void Shuffle<T>(this IList<T> myList)
	{
		int n = list.Count;
		while (n > 1) {
			n--;
			int k = getRandom().Next(n + 1);
			T value = list[k];
			list[k] = list[n];
			list[n] = value;
		}
	}
}
