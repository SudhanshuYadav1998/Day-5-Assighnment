﻿Console.WriteLine("Enter an Alphabet");
char alp = Convert.ToChar(Console.ReadLine());
if (alp == 'a'  || alp == 'A' || alp == 'e'|| alp == 'E' || alp == 'i' || alp == 'I' ||
    alp == 'o' || alp == 'O' || alp == 'u' || alp == 'U')
{
    Console.WriteLine("Enterd Alphabet is a VOWEL");

}
else
    Console.WriteLine("Entered Alphabet is consonant");