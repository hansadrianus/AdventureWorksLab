namespace Cr8ive_AlbertusSandhy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World! My name is Hans and I love programming";
            string text1 = "My best friend is Hans";
            string text2 = "Hans is working at Coca Cola";
            string text3 = "Albertus and Hans are friends";
            string text4 = "Programming is not hard";
            string text5 = "Hard is not Hans";
            string text6 = "Hans name always called Hans";
            string text7 = "I did not has any twin";
            string text8 = "Albertus learning programming from OpenAI";
            string text9 = "This is substring subject";

            string output = text.Substring(text.LastIndexOf(' ')).Trim();
            string output1 = text1.Substring(text1.LastIndexOf(' ')).Trim();
            string output2 = text2.Substring(text2.LastIndexOf(' ')).Trim();
            string output3 = text3.Substring(text3.LastIndexOf(' ')).Trim();
            string output4 = text4.Substring(text4.LastIndexOf(' ')).Trim();
            string output5 = text5.Substring(text5.LastIndexOf(' ')).Trim();
            string output6 = text6.Substring(text6.LastIndexOf(' ')).Trim();
            string output7 = text7.Substring(text7.LastIndexOf(' ')).Trim();
            string output8 = text8.Substring(text8.LastIndexOf(' ')).Trim();
            string output9 = text9.Substring(text9.LastIndexOf(' ')).Trim();

            Console.WriteLine(text + " " + text.Length);
            Console.WriteLine(text1 + " " + text1.Length);
            Console.WriteLine(text2 + " " + text2.Length);
            Console.WriteLine(text3 + " " + text3.Length);
            Console.WriteLine(text4 + " " + text4.Length);
            Console.WriteLine(text5 + " " + text5.Length);
            Console.WriteLine(text6 + " " + text6.Length);
            Console.WriteLine(text7 + " " + text7.Length);
            Console.WriteLine(text8 + " " + text8.Length);
            Console.WriteLine(text9 + " " + text9.Length);

            Console.WriteLine();

            Console.WriteLine(output + " " + output.Length);
            Console.WriteLine(output1 + " " + output1.Length);
            Console.WriteLine(output2 + " " + output2.Length);
            Console.WriteLine(output3 + " " + output3.Length);
            Console.WriteLine(output4 + " " + output4.Length);
            Console.WriteLine(output5 + " " + output5.Length);
            Console.WriteLine(output6 + " " + output6.Length);
            Console.WriteLine(output7 + " " + output7.Length);
            Console.WriteLine(output8 + " " + output8.Length);
            Console.WriteLine(output9 + " " + output9.Length);
        }
    }
}
