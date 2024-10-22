namespace Task.Challenges.Arrays;

public static class ReverseArray
{
    public static T[] ToReverseArray<T>(this T[] array)
    {
        if(array == null) throw new ArgumentNullException(nameof(array));

        T[] reversedArray = new T[array.Length];

        for(int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - i - 1];
            //5 elements => rA[0] = ar[5 - 0 -1 = 4]
        }

        return reversedArray;
    }
}
