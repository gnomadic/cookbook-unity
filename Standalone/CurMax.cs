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
using System;


/**
* CurMax can be used to maintain two values:  one representing current state, and the other for max state.
* This is useful for things like Health, if Gold has a wallet size limit, etc.
*/
[System.Serializable]
public class CurMax {
  public double current { get ; private set; }
  public double maximum { get ; private set; }

  public CurMax(double maxValue){
    this.maximum = maxValue;
    this.current = maxValue;
  }

  public CurMax(double currentValue, double maxValue){
    this.current = currentValue;
    this.maximum = maxValue;
    sanitize();
  }

  /// <summary>
  /// Set the current value and ensure it is no greater than the max or less than 0.
  /// </summary>
  /// <param name="newCurrent">The new current value.</param>
  public void set(double newCurrent){
    current = newCurrent;
    sanitize();
  }

  /// <summary>
  /// Add to the current value and ensure it is no greater than the max or less than 0.
  /// </summary>
  /// <param name="addToCurrent">Value to add to current.</param>
  public void add(double addToCurrent){
    current += addToCurrent;
    sanitize();
  }

  /// <summary>
  /// Subtract from the current value and ensure it is no greater than the max or less than 0.
  /// </summary>
  /// <param name="removeFromCurrent">Value to remove from current.</param>
  public void sub(double removeFromCurrent){
    current -= removeFromCurrent;
    sanitize();
  }

  /// <summary>
  /// Returns true when the current value is 0
  /// </summary>
  public bool isEmpty(){
    return (this.current == 0);
  }

  private void sanitize(){
    if (current > maximum){
      current = maximum;
    }
    if (current < 0) {
      current = 0;
    }
  }
}
