
#region Ədədlərdən ibarət olan, verilmiş arrayin ədədi ortasını tapın.
//int[] arr = { 1, 2, 3, 4 };
//float sum = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    sum = sum + arr[i];

//}
//float avarage = sum/arr.Length;
//Console.WriteLine(avarage);
#endregion
#region Ədədlərdən ibarət olan arraydə neçə müsbət neçə mənfi ədəd olduğunu ekrana çıxardan alqoritm yazın.
//int[] arr = {-2,-1,1,2,3 };
//int count=0;
//int count1=0;
//for (int i = 0; i < arr.Length; i++) {

//	if (arr[i] < 0)
//	{
//		count++;
//	}
//    else if (arr[i] > 0) {
//		count1++;
//	}
//}
//Console.WriteLine("Count of positive number: "+count1) ;
//Console.WriteLine("Count of negative number: " + count);
#endregion
#region Ədədlərdən ibarət olan bir array verilib həmin arraydə olan ən böyük ədədi ekrana yazdıran alqoritm yazın.
//Biz verilmis arraydaki ededlerden en boyuyunu tapmaq ucun o-ci indexi max goturub daha sonra ise diger indexlerle muqayise edirik.
//Eger boyuk olan olarsa max-a yeni deyer olaraq o menimsedilir.
int[] arr={1,2,100,3,4};
int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
	if (arr[i]>max)
	{
		max = arr[i];
	}
}
Console.WriteLine("Largest number of array: " + max);
#endregion