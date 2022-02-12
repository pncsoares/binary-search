﻿namespace SearchAlgorithms;

public class LinearSearch : IArraySearch
{
    public int Search(int[] array, int item)
    {
        if (array == null)
        {
            return -1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == item)
            {
                return i;
            }
        }

        // you must pass -1 because array starts in zero
        // zero is a valid position and represents the beginning of the array
        return -1; 
    }
}