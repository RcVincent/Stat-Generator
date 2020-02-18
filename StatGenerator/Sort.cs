using System;
using System.Collections.Generic;
using System.Text;

namespace StatGenerator
{
    public class Sort
    {
        public void Insertsort(int[] arr)
        {
            //itterate along the array
            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                //move the elements to their sorted position in the array
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }
}
