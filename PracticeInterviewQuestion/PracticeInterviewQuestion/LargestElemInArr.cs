namespace PracticeInterviewQuestion;

public class LargestElemInArr
{
    public void FindLargestElement(int[] arr)
    {
        int max = Int32.MinValue;

        for(int i = 0; i < arr.Length; i++){
            if(arr[i] > max){
                max = arr[i];
            }
        }

        Console.WriteLine(max);
    }
}