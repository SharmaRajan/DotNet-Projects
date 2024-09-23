namespace PracticeInterviewQuestion;

public class VowelCount
{

    public void VowelsCount(String str)
    {
        char[] ch = str.ToCharArray();
        int count = 0;

        for (int i = 0; i < ch.Length; i++)
        {
            if (isVowel(ch[i]))
                count++;
        }
        
        Console.WriteLine("The vowel count: " + count);
    }
    
    public  Boolean isVowel(char ch){
        switch (ch){
            case 'a': case 'A': case 'e': case 'E': case 'i': case 'I': case 'o': case 'O': case 'U': case 'u':
                return true;
            default:
                return false;
        }
    }
}