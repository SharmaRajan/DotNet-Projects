// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");


using PracticeInterviewQuestion;


// Array Sorting
int[] arr = {9,5, 10, 43, 76, 12, 21};

ArraySort sort = new ArraySort();
sort.ArraySortAsc(arr);
sort.ArraySortDesc(arr);

Console.WriteLine();


// Vowel Count
VowelCount vowel = new VowelCount();
        
String str = "Hey there vowels cOunt";
        
vowel.VowelsCount(str);


// Find maximum element in an arr
LargestElemInArr largest = new LargestElemInArr();
largest.FindLargestElement(arr);

// Prime number
PrimeNumber prime = new PrimeNumber();
prime.printPrime(arr);
