namespace UyIshi1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-mavzu
            //int natija = Qoshish(5, 7);
            //Console.WriteLine(natija);

            //static int Qoshish(int a, int b)
            //{
            //    return a + b;
            //}





            //2-mavzu

            //static string Almashtir(string str)
            //{
            //    return str.Replace('x', 'y')
            //              .Replace('y', 'z');
            //}

            //    string matn = "xayxy";
            //    string natija = Almashtir(matn);

            //    Console.WriteLine(natija);

            //3-mavzu

            //static int KichikHarfSoni(string str)
            //{
            //    int count = 0;

            //    foreach (char c in str)
            //    {
            //        if (char.IsLower(c))
            //            count++;
            //    }

            //    return count;
            //}
            //string matn = "Salom CSharp123";
            //int natija = KichikHarfSoni(matn);

            //Console.WriteLine(natija);

            //4-mavzu

            static int ToqSonlarSoni(int a, int b)
            {
                int count = 0;
                for (int i = a + 1; i < b; i++)
                    if (i % 2 != 0) count++;
                return count;
            }
            Console.WriteLine(ToqSonlar(3, 15));
            //5-mavzu 

            //static int XonaSoni(int n)
            //{
            //    n = Math.Abs(n);
            //    return n.ToString().Length;
            //}

            //Console.WriteLine(XonaSoni(1234));

            ////6-mavzu

            //static bool FaqatRaqammi(string str)
            //{
            //    foreach (char c in str)
            //        if (!char.IsDigit(c)) return false;
            //    return true;
            //}
            //Console.WriteLine(FaqatRaqam("3243"));


            ////7-mavzu
            //static bool Tubmi(int n)
            //{
            //    if (n < 2) return false;
            //    for (int i = 2; i <= Math.Sqrt(n); i++)
            //        if (n % i == 0) return false;
            //    return true;
            //}

            //Console.WriteLine(Tub(17));
            ////8-mavzu
            //static string Teskari(string str)
            //{
            //    char[] arr = str.ToCharArray();
            //    Array.Reverse(arr);
            //    return new string(arr);
            //}
            //Console.WriteLine(Teskari("salom"));

            ////9-mavzu
            //static int SpaceSoni(string str)
            //{
            //    int count = 0;
            //    foreach (char c in str)
            //        if (c == ' ') count++;
            //    return count;
            //}
            //Console.WriteLine(SpaceSoni("salom dunyo"));

            ////10-mavzu
            //static bool Palindrommi(string str)
            //{
            //    string rev = Teskari(str);
            //    return str == rev;
            //}
            //Console.WriteLine(Palindrom("level"));

            ////11-mavzu
            //static int RaqamlarSoni(string str)
            //{
            //    int count = 0;
            //    foreach (char c in str)
            //        if (char.IsDigit(c)) count++;
            //    return count;
            //}
            //Console.WriteLine(RaqamSoni("a1b2"));

            ////12-mavzu
            //static int KattaHarfSoni(string str)
            //{
            //    int count = 0;
            //    foreach (char c in str)
            //        if (char.IsUpper(c)) count++;
            //    return count;
            //}
            //Console.WriteLine(KattaSoni("SaLOm"));

            ////13-mavzu
            //static bool HammaKattami(string str)
            //{
            //    foreach (char c in str)
            //        if (!char.IsUpper(c)) return false;
            //    return true;
            //}
            //Console.WriteLine(HammaKatta("HELLO"));

            ////14-mavzu
            //static bool HammaKichikmi(string str)
            //{
            //    foreach (char c in str)
            //        if (!char.IsLower(c)) return false;
            //    return true;
            //}
            //Console.WriteLine(HammaKichik("salom"));

            ////15-mavzu 
            //static string KichikniKatta(string str)
            //{
            //    return str.ToUpper();
            //}
            //Console.WriteLine(KichikKatta("salom"));

            ////16-mavzu
            //static int OkSoni(string str)
            //{
            //    int count = 0;
            //    for (int i = 0; i < str.Length - 1; i++)
            //        if (str.Substring(i, 2) == "ok") count++;
            //    return count;
            //}
            //Console.WriteLine(OkSoni("okok ok"));

            ////17-mavzu
            //static string KichikYulduz(string str)
            //{
            //    char[] arr = str.ToCharArray();
            //    for (int i = 0; i < arr.Length; i++)
            //        if (char.IsLower(arr[i])) arr[i] = '*';
            //    return new string(arr);
            //}
            //Console.WriteLine(KichikYulduz("SaLoM"));

            ////18-mavzu
            //static string KattaniKichik(string str)
            //{
            //    return str.ToLower();
            //}
            // Console.WriteLine(KattaKichik("HELLO"));

            ////19-mavzu
            //static string KattaniKichik(string str)
            //{
            //    return str.ToLower();
            //}


            ////20-mavzu
            //static int AtSoni(string str)
            //{
            //    int count = 0;
            //    foreach (char c in str)
            //        if (c == '@') count++;
            //    return count;
            //}
            //Console.WriteLine(AtSoni("a@b@@c"));


            //21-masala


            //static string helloName(string name) => "Hello " + name + "!";
            //Console.WriteLine(helloName("Aziz"));


            ////22-masala



            //static string makeAbba(string a, string b) => a + b + b + a;
            //Console.WriteLine(makeAbba("Hi", "Bye"));


            ////23-masala


            //static string makeOutWord(string a, string b) => a.Substring(0, 2) + b + a.Substring(2);
            //Console.WriteLine(makeOutWord("<<>>", "Yay"));


            ////24-masala


            //static string extraEnd(string s)
            //{
            //    string last2 = s.Substring(s.Length - 2);
            //    return last2 + last2 + last2;
            //}
            //Console.WriteLine(extraEnd("Hello"));


            ////25-masala


            //static string firstTwo(string s) => s.Length < 2 ? s : s.Substring(0, 2);
            //Console.WriteLine(firstTwo("Hello"));

            ////26-masala


            //static string firstHalf(string s) => s.Substring(0, s.Length / 2);
            //Console.WriteLine(firstHalf("WooHoo"));


            ////27-masala


            //static string withoutEnd(string s) => s.Substring(1, s.Length - 2);
            //Console.WriteLine(withoutEnd("Hello"));

            ////28-masala


            //static string comboString(string a, string b) => a.Length < b.Length ? a + b + a : b + a + b;
            //Console.WriteLine(comboString("Hello", "hi"));

            ////29-masala


            //static string nonStart(string a, string b) => a.Substring(1) + b.Substring(1);
            //Console.WriteLine(nonStart("Hello", "There"));

            ////30-masala


            //static string left2(string s) => s.Length <= 2 ? s : s.Substring(2) + s.Substring(0, 2);
            //Console.WriteLine(left2("Hello"));


            ////31-masala


            //static string theEnd(string s, bool front) => front ? s[0].ToString() : s[^1].ToString();
            //Console.WriteLine(theEnd("Hello", true));


            ////32-masala


            //static string nTwice(string s, int n) => s.Substring(0, n) + s.Substring(s.Length - n);
            //Console.WriteLine(nTwice("Chocolate", 3));

            ////33-masala


            //static string middleThree(string s) => s.Substring(s.Length / 2 - 1, 3);
            // Console.WriteLine(middleThree("Candy"));


            ////34-masala


            //static string conCat(string a, string b)
            //{
            //    if (a.Length > 0 && b.Length > 0 && a[^1] == b[0])
            //        return a + b.Substring(1);
            //    return a + b;
            //}
            //Console.WriteLine(conCat("abc", "cat"));


            ////35-masala

            //static string lastTwo(string s)
            //{
            //    if (s.Length < 2) return s;
            //    return s.Substring(0, s.Length - 2) + s[^1] + s[^2];
            //}
            //Console.WriteLine(lastTwo("coding"));


            ////36-masala


            //static string seeColor(string s)
            //{
            //    if (s.StartsWith("red")) return "red";
            //    if (s.StartsWith("blue")) return "blue";
            //    return "";
            //}
            //Console.WriteLine(seeColor("redxx"));


            ////37-masala


            //static bool frontAgain(string s)
            //{
            //    if (s.Length < 2) return false;
            //    return s.StartsWith(s.Substring(s.Length - 2));
            //}
            //Console.WriteLine(frontAgain("edited"));


            ////38-masala


            //static string minCat(string a, string b)
            //{
            //    int min = Math.Min(a.Length, b.Length);
            //    return a.Substring(a.Length - min) + b.Substring(b.Length - min);
            //}
            //Console.WriteLine(minCat("Hello", "Hi"));


            ////39-masala


            //static string deFront(string s)
            //{
            //    string r = "";
            //    if (s[0] == 'a') r += 'a';
            //    if (s.Length > 1 && s[1] == 'b') r += 'b';
            //    return r + s.Substring(2);
            //}
            //Console.WriteLine(deFront("away"));


            ////40-masala

            //static string withoutX(string s)
            //{
            //    if (s.StartsWith("x")) s = s.Substring(1);
            //    if (s.EndsWith("x")) s = s.Substring(0, s.Length - 1);
            //    return s;
            //}
            //Console.WriteLine(withoutX("xHix"));


            ////41-masala
            ///

            //static string RemoveDigits(string text)
            //{
            //    string result = "";
            //    foreach (char ch in text)
            //        if (!char.IsDigit(ch)) result += ch;
            //    return result;
            //}
            //Console.WriteLine(removeDigits("a1b2c3"));


            ////42-masala
            ///


            //static string RemoveUpperLetters(string text)
            //{
            //    string result = "";
            //    foreach (char ch in text)
            //        if (!char.IsUpper(ch)) result += ch;
            //    return result;
            //}
            //Console.WriteLine(removeUpperLetters("SaLOm"));


            ////43-masala


            //static string RemoveLowerLetters(string text)
            //{
            //    string result = "";
            //    foreach (char ch in text)
            //        if (!char.IsLower(ch)) result += ch;
            //    return result;
            //}
            //Console.WriteLine(removeLowerLetters("SaLOm"));

            ////44-masala


            //static string RemoveAtSymbol(string text)
            //{
            //    string result = "";
            //    foreach (char ch in text)
            //        if (ch != '@') result += ch;
            //    return result;
            //}
            //Console.WriteLine(removeAtSymbol("a@b@@c"));


            ////45-masala
            ///

            //static string RemoveSpaces(string text)
            //{
            //    string result = "";
            //    foreach (char ch in text)
            //        if (ch != ' ') result += ch;
            //    return result;
            //}
            //Console.WriteLine(removeSpaces("salom dunyo"));

            //45-masala
            //static string FirstNLastN(string s1, int N1, string s2, int N2)
            //{
            //    string part1 = s1.Substring(0, Math.Min(N1, s1.Length));
            //    string part2 = s2.Substring(Math.Max(0, s2.Length - N2));
            //    return part1 + part2;
            //}
            //Console.WriteLine(FirstNLastN("HelloWorld", 3, "Programming", 4));


            ////46-masala


            //static string DoubleChar(string s, char c)
            //{
            //    string result = "";
            //    foreach (char ch in s)
            //    {
            //        if (ch == c) result += new string(c, 2);
            //        else result += ch;
            //    }
            //    return result;
            //}
            //Console.WriteLine(DoubleChar("apple", 'p'));


            ////47-masala

            //static string InsertBeforeChar(string s1, string s2, char c)
            //{
            //    string result = "";
            //    foreach (char ch in s1)
            //    {
            //        if (ch == c) result += s2 + ch;
            //        else result += ch;
            //    }
            //    return result;
            //}

            //Console.WriteLine(InsertBeforeChar("banana", "X", 'a'));

            ////48-masala
            //static string InsertAfterChar(string s1, string s2, char c)
            //{
            //    string result = "";
            //    foreach (char ch in s1)
            //    {
            //        result += ch;
            //        if (ch == c) result += s2;
            //    }
            //    return result;
            //}
            //Console.WriteLine(InsertAfterChar("banana", "X", 'a'));

            ////49-masala

            //static int CountSubstr(string s1, string s2)
            //{
            //    int count = 0, index = 0;
            //    while ((index = s1.IndexOf(s2, index)) != -1)
            //    {
            //        count++;
            //        index += s2.Length;
            //    }
            //    return count;
            //}

            //Console.WriteLine(CountSubstr("ababab", "ab"));

            ////50-masala
            //static string RemoveFirstSubstr(string s1, string s2)
            //{
            //    int index = s1.IndexOf(s2);
            //    if (index == -1) return s1;
            //    return s1.Remove(index, s2.Length);
            //}
            //Console.WriteLine(RemoveFirstSubstr("Hello there", "lo"));


            ////51-masala
            //static string RemoveLastSubstr(string s1, string s2)
            //{
            //    int index = s1.LastIndexOf(s2);
            //    if (index == -1) return s1;
            //    return s1.Remove(index, s2.Length);
            //}
            //Console.WriteLine(RemoveLastSubstr("Hello there there", "there"));


            ////52-masala
            //static string RemoveAllSubstr(string s1, string s2)
            //{
            //    return s1.Replace(s2, "");
            //}

            //Console.WriteLine(RemoveAllSubstr("ababab", "ab"));

            ////53-masala
            //static string ReplaceFirstSubstr(string s1, string s2, string s3)
            //{
            //    int index = s1.IndexOf(s2);
            //    if (index == -1) return s1;
            //    return s1.Substring(0, index) + s3 + s1.Substring(index + s2.Length);
            //}

            //Console.WriteLine(ReplaceFirstSubstr("Hello there", "lo", "XX"));

            ////54-masala
            //static string ReplaceLastSubstr(string s1, string s2, string s3)
            //{
            //    int index = s1.LastIndexOf(s2);
            //    if (index == -1) return s1;
            //    return s1.Substring(0, index) + s3 + s1.Substring(index + s2.Length);
            //}

            //Console.WriteLine(ReplaceLastSubstr("Hello there hello", "he", "YY"));

            ////55-masala
            //static string ReplaceAllSubstr(string s1, string s2, string s3)
            //{
            //    return s1.Replace(s2, s3);
            //}

            //Console.WriteLine(ReplaceAllSubstr("ababab", "ab", "X"));


            ////56-masala
            //static string BetweenFirstTwoSpaces(string s)
            //{
            //    int first = s.IndexOf(' ');
            //    int second = s.IndexOf(' ', first + 1);
            //    if (first == -1 || second == -1) return "";
            //    return s.Substring(first + 1, second - first - 1);
            //}

            //Console.WriteLine(BetweenFirstTwoSpaces("I am learning"));

            ////57-masala
            //static bool CatDog(string s)
            //{
            //    int cat = 0, dog = 0;
            //    for (int i = 0; i <= s.Length - 3; i++)
            //    {
            //        if (s.Substring(i, 3) == "cat") cat++;
            //        if (s.Substring(i, 3) == "dog") dog++;
            //    }
            //    return cat == dog;
            //}
            //Console.WriteLine(CatDog("catdog"));


            ////58-masala
            //static int CountCode(string s)
            //{
            //    int count = 0;
            //    for (int i = 0; i <= s.Length - 4; i++)
            //    {
            //        if (s.Substring(i, 2) == "co" && s[i + 3] == 'e') count++;
            //    }
            //    return count;
            //}

            //Console.WriteLine(CountCode("cooe"));


            ////59-masala
            //static bool EndOther(string a, string b)
            //{
            //    a = a.ToLower();
            //    b = b.ToLower();
            //    return a.EndsWith(b) || b.EndsWith(a);
            //}
            //Console.WriteLine(EndOther("Hiabc", "abc"));


            ////60-masala
            //static bool XyzThere(string s)
            //{
            //    for (int i = 0; i <= s.Length - 3; i++)
            //    {
            //        if (s.Substring(i, 3) == "xyz")
            //        {
            //            if (i == 0 || s[i - 1] != '.') return true;
            //        }
            //    }
            //    return false;
            //}
            //Console.WriteLine(XyzThere("abc.xyzxyz"));


            ////61-masala
            //static string MixString(string a, string b)
            //{
            //    string result = "";
            //    int n = Math.Min(a.Length, b.Length);
            //    for (int i = 0; i < n; i++)
            //        result += a[i].ToString() + b[i].ToString();
            //    if (a.Length > n) result += a.Substring(n);
            //    if (b.Length > n) result += b.Substring(n);
            //    return result;
            //}
            //Console.WriteLine(MixString("abc", "xyz"));


            ////62-masala
            //static string RepeatEnd(string s, int n)
            //{
            //    string last = s.Substring(s.Length - n);
            //    string result = "";
            //    for (int i = 0; i < n; i++) result += last;
            //    return result;
            //}
            // Console.WriteLine(RepeatEnd("Hello", 3));


            ////63-masala
            //static string RepeatFront(string s, int n)
            //{
            //    string result = "";
            //    for (int i = n; i > 0; i--)
            //    {
            //        result += s.Substring(0, i);
            //    }
            //    return result;
            //}
            //Console.WriteLine(RepeatFront("Chocolate", 4));

            ////64-masala
            //static string RepeatSeparator(string word, string sep, int n)
            //{
            //    if (n == 0) return "";
            //    string result = word;
            //    for (int i = 1; i < n; i++)
            //        result += sep + word;
            //    return result;
            //}
            // Console.WriteLine(RepeatSeparator("Word", "X", 3));


            ////65-masala
            //static bool PrefixAgain(string s, int n)
            //{
            //    string prefix = s.Substring(0, n);
            //    return s.Substring(n).Contains(prefix);
            //}
            //Console.WriteLine(PrefixAgain("abXYabc", 2));


            ////66-masala
            //static bool XyzMiddle(string s)
            //{
            //    int mid = s.Length / 2;
            //    int left = mid - 1, right = mid + 2;
            //    if (s.Length < 3) return false;
            //    for (int i = 0; i <= s.Length - 3; i++)
            //    {
            //        if (s.Substring(i, 3) == "xyz")
            //        {
            //            int leftLen = i;
            //            int rightLen = s.Length - (i + 3);
            //            if (Math.Abs(leftLen - rightLen) <= 1) return true;
            //        }
            //    }
            //    return false;
            //}
            //Console.WriteLine(XyzMiddle("AxyzBB"));


            ////67-masala
            //static string GetSandwich(string s)
            //{
            //    int first = s.IndexOf("bread");
            //    int last = s.LastIndexOf("bread");
            //    if (first == -1 || last == -1 || first == last) return "";
            //    return s.Substring(first + 5, last - first - 5);
            //}
            //Console.WriteLine(GetSandwich("xxbreadjambreadyy"));


            ////68-masala
            //static bool SameStarChar(string s)
            //{
            //    for (int i = 1; i < s.Length - 1; i++)
            //    {
            //        if (s[i] == '*' && s[i - 1] == s[i + 1]) return true;
            //    }
            //    return false;
            //}
            //Console.WriteLine(SameStarChar("xy*yzz"));


            ////69-masala
            //static string ZipZap(string s)
            //{
            //    string result = "";
            //    int i = 0;
            //    while (i < s.Length)
            //    {
            //        if (i + 2 < s.Length && s[i] == 'z' && s[i + 2] == 'p')
            //        {
            //            result += "zp";
            //            i += 3;
            //        }
            //        else
            //        {
            //            result += s[i];
            //            i++;
            //        }
            //    }
            //    return result;
            //}
            // Console.WriteLine(ZipZap("zipXzap"));


            ////70-masala
            //static string PlusOut(string s, string word)
            //{
            //    string result = "";
            //    int i = 0;
            //    while (i < s.Length)
            //    {
            //        if (i <= s.Length - word.Length && s.Substring(i, word.Length) == word)
            //        {
            //            result += word;
            //            i += word.Length;
            //        }
            //        else
            //        {
            //            result += "+";
            //            i++;
            //        }
            //    }
            //    return result;
            //}
            //Console.WriteLine(PlusOut("12xy34", "xy"));


            ////71-masala
            //static string WordEnds(string s, string word)
            //{
            //    string result = "";
            //    for (int i = 0; i <= s.Length - word.Length; i++)
            //    {
            //        if (s.Substring(i, word.Length) == word)
            //        {
            //            if (i > 0) result += s[i - 1];
            //            if (i + word.Length < s.Length) result += s[i + word.Length];
            //        }
            //    }
            //    return result;
            //}
            //Console.WriteLine(WordEnds("abcXY123XYijk", "XY"));


            ////72-masala
            //static int CountYZ(string s)
            //{
            //    s = s.ToLower();
            //    string[] words = s.Split(new char[] { ' ', '.', '!', '?', ':', '-', ';' }, StringSplitOptions.RemoveEmptyEntries);
            //    int count = 0;
            //    foreach (var word in words)
            //    {
            //        if (word.EndsWith("y") || word.EndsWith("z")) count++;
            //    }
            //    return count;
            //}
            // Console.WriteLine(CountYZ("fez day"));


            ////73-masala
            //static string WithoutString(string s, string remove)
            //{
            //    return s.Replace(remove, "");
            //}
            //Console.WriteLine(WithoutString("Hello there", "llo"));


            ////74-masala
            //static bool EqualIsNot(string s)
            //{
            //    int isCount = 0, notCount = 0;
            //    for (int i = 0; i <= s.Length - 2; i++)
            //    {
            //        if (s.Substring(i, 2) == "is") isCount++;
            //    }
            //    for (int i = 0; i <= s.Length - 3; i++)
            //    {
            //        if (s.Substring(i, 3) == "not") notCount++;
            //    }
            //    return isCount == notCount;
            //}
            //Console.WriteLine(EqualIsNot("This is notnot"));


            ////75-masala
            //static bool GHappy(string s)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (s[i] == 'g')
            //        {
            //            bool left = i > 0 && s[i - 1] == 'g';
            //            bool right = i < s.Length - 1 && s[i + 1] == 'g';
            //            if (!left && !right) return false;
            //        }
            //    }
            //    return true;
            //}
            //Console.WriteLine(GHappy("xxggxx"

            ////76-masala
            //static int CountTriple(string s)
            //{
            //    int count = 0;
            //    for (int i = 0; i <= s.Length - 3; i++)
            //    {
            //        if (s[i] == s[i + 1] && s[i] == s[i + 2]) count++;
            //    }
            //    return count;
            //}

            //Console.WriteLine(CountTriple("xxxabyyyycd"));


            ////77-masala



            //static int SumDigits(string s)
            //{
            //    int sum = 0;
            //    foreach (char ch in s)
            //    {
            //        if (char.IsDigit(ch)) sum += ch - '0';
            //    }
            //    return sum;
            //}
            //Console.WriteLine(SumDigits("aa1bc2d3"));

        }

    }
}
