/* 2 класи: рослини, тварини
 Рослини: куші, дерева, трава
 Тварини: свійські
 інтерфейс: feed, showinfo
 output: надо покормить или не надо, если надо вывести сколько нужно еще дать корма и showinfo;
 */

using dodatkove;
class Program
{
    static void Main(string[] args)
    {
        Plants[] plants = new Plants[] { new Tree("дерево", 200), new Bush("кущ", 100), new Grass("канабис", 50) };
        foreach (var i in plants)
        {
            Console.WriteLine(i.ShowInfo());
            Console.WriteLine(i.Feed(int.Parse(Console.ReadLine())));
            
        }
    }
}
