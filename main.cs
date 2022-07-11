using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class Program {

    public static string reverseString(string text){
    //Input: string
    //Output reversed string
    //Example: "Tower" should return "rewot"
    string result = "";
    for(int i = text.Length-1; i >= 0; i--){
      result += text[i];
    }
    Console.WriteLine(result);
    return result;
  }

  public static string reverseString2(string text){
    //Input: string
    //Output reversed string
    //Example: "Tower" should return "rewot"
    char[] charArray = text.ToCharArray();
    Array.Reverse( charArray );
    var anotherOption = text.ToCharArray().Reverse().ToArray();
    Console.WriteLine(anotherOption);
    return new string( charArray );
  }

  public static string reverseString3(string text){
    //Input: string
    //Output reversed string
    //Example: "Tower" should return "rewot"
    var outPutstr = string.Empty; 
    foreach (var item in text.ToCharArray()) { 
      outPutstr = item + outPutstr; 
    }
    Console.WriteLine("Reverse of '" + text + "': " + outPutstr);
    return outPutstr;
  }

  public static int[] mergeSortedArray(int[] arr1, int[] arr2){
    //Input: two sorted arrays
    //Output meged and sorted array
    //Example: [1,3,5], [2,4,6] should return [1,2,3,4,5,6]
    int length1 = arr1.Length;
    int length2 = arr2.Length;
    if(length1 == 0) return arr2;
    if(length2 == 0) return arr1;
    if(length1 == 0 && length2 == 0) return null;
    int[] mergedArr = new int[length1+length2];
    //i for first arr, j for second arr and k for merged arr
    int i = 0, j = 0, k = 0;
      
    while(i < length1 && j < length2){
      if(arr1[i] <= arr2[j]){
        mergedArr[k] = arr1[i];
        i++;
        k++;
      }else{
        mergedArr[k] = arr2[j];
        j++;
        k++;
      }
    }

   //next whiles are used for mergin the remaining items if exists
   while(i < length1){
      mergedArr[k] = arr1[i];
      i++;
       k++;
   }

   while(j < length2){
       mergedArr[k] = arr2[j];
       j++;
       k++;
   }
    return mergedArr;
  }

  public static int[] mergeSortedArray2(int[] arr1, int[] arr2){
    //Input: two sorted arrays
    //Output meged and sorted array
    //Example: [1,3,5], [2,4,6] should return [1,2,3,4,5,6]
    arr1 = arr1.Concat(arr2).ToArray();
    Array.Sort(arr1);
    return arr1;
  }

  
  
  public static void Main (string[] args) {
    reverseString("tower of babel");// Big O notation = 0(n) --> Linear Time

    var reverseResult = reverseString2("tower of babel");//Big O notation 0(1) --> Constant Time
    Console.WriteLine(reverseResult);

    reverseString3("tower of babel");// Big O notation = 0(n) --> Linear Time

    int[] arr1 = {1,3,5};
    int[] arr2 = {};
    var arrResult = mergeSortedArray(arr1,arr2);
    Array.ForEach(arrResult, Console.WriteLine);
    var arrResult2 = mergeSortedArray2(arr1,arr2);
    Array.ForEach(arrResult2, Console.WriteLine);
    
  }
}