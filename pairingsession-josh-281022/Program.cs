using System.Diagnostics;

namespace pairingsession_josh_281022;

public class Program
{
    public static void Main(String[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();
        
        Console.WriteLine("1");

        int bignumber = 100_000_000;

        int[] list = new int[bignumber];
        
        for (int i = 0; i < bignumber; i++)
        {
            list[i] = i;
        }
        
        Console.WriteLine("1.5");
        
        
        
        
        var random = new Random();
        
        Shuffle(list);
        
        
        Console.WriteLine("1.6");
        
        for (int i = 0; i < bignumber; i++)
        {
            bst.insert(list[i]);
        }
        
    
        
        Console.WriteLine("2");
        
        
        

        var s = Stopwatch.StartNew();
        
        Console.WriteLine(bst.SearchAlgoIterative(520_030));
        
        s.Stop();
        var elapsedMs = s.ElapsedMilliseconds;
        Console.WriteLine("Time1: " + elapsedMs);



        var a = Stopwatch.StartNew();
        
        Console.WriteLine(list.Contains(520_030));
        
        a.Stop();
        
        var elapsedMs2 = a.ElapsedMilliseconds;
        Console.WriteLine("Time2: " + elapsedMs2);

    }
    // probably "static" should be added (depends on GenerateAnotherNum routine)

    public static int[] Shuffle(int[] items)
    {
        var random = new Random();
        for(int i = 0; i < items.Length - 1; i++)
        {
            int pos = random.Next(i, items.Length); 
            int temp = items[i];          
            items[i] = items[pos];
            items[pos] = temp;
        }
        return items;
    }
}