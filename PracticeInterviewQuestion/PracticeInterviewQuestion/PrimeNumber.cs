namespace PracticeInterviewQuestion;

public class PrimeNumber
{
    public void printPrime(int[] arr){

        for(int i = 0; i < arr.Length; i++){
            if(IsPrime(arr[i]))
                Console.WriteLine(arr[i] + " is prime");
        }
    }

    private Boolean IsPrime(int num){
        for(int i = 2; i < num/2; i++){
            if((num % i) == 0)
                return false;
        }
        return true;
    }
}