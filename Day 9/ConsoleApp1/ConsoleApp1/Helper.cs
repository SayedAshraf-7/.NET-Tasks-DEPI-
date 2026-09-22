namespace Task
{
    static class Helper<T>
    {
        public static void Swap(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        public static int SearchArr(T[] Arr, T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Value.Equals((Arr[i])))
                    return i;
            }
            return -1;
        }

        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public static void ReplaceArray(T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array?.Length; i++)
            {
                if (array[i].Equals(oldValue))
                {
                    array[i] = newValue;
                }
            }
        }

    }


}
