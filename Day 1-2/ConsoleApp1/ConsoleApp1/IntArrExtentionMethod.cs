public static class IntArrExtentionMethod
{
    public static int Sum2(this int[] arr)
    {
        int sm = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sm += arr[i];
        }
        return sm;
    }
}
