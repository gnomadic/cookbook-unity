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

public static class BigNumbers {

    private static List<string> orders = new List<string> (){
        "K",
        "M",
        "B",
        "T",
        "QUA",
        "QIU",
        "SEXT",
        "SEPT",
        "OCT",
        "NON",
        "DEC"};

    /// <summary>
    /// Remove and return the first item.
    /// </summary>
    /// <param name="myList">My list.</param>
    public static BigValue parse(int count){
        BigValue ret = new BigValue ();
        if (count < 1000) {
            ret.number = count;
            ret.order = "";
            return ret;
        }
        int exp = (int) (Mathf.Log (count) / Mathf.Log (1000));
        ret.number = (double) (count / Mathf.Pow (1000, exp));
        ret.order = orders[exp - 1];

        return ret;
    }

    [System.Serializable]
    public class BigValue{
        public double number;
        public string order;
    }
}
