namespace PracticeInterviewQuestion;

public class ArraySort
{
    public void ArraySortAsc(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    Swap(arr, i, j);
                }
            }
        }
    
        foreach(int val in arr)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine();   
    }


    public void ArraySortDesc(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    Swap(arr, i, j);
                }
            }
        }
    
        foreach(int val in arr)
        {
            Console.Write(val + " ");
        }
    }

    public void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}