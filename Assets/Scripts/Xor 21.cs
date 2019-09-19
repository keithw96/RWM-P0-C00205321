using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Xor21
{
    public void Xor21f()
    {
        int[] input = { 4, 2, 8, 3, 9, 4, 10 };
        int[] output = new int[input.Length];

        int temp = 0;

        for (int i = 0; i < input.Length; i++ )
        {
            if(input[i]%2 == 0)
            {
                temp = (3 *input[i]) + 1;
            }

            else
            {
                temp = input[i] / 2;
            }

            output[i] = temp;

        }

    }
}
