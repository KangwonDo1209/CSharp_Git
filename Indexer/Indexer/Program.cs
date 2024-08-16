using static System.Runtime.InteropServices.JavaScript.JSType;

class MyIndexer<Key, Value>
{
	private Dictionary<Key, Value> dic;

	public MyIndexer()
	{
		dic = new Dictionary<Key, Value>();
	}

	public Value this[Key key]
	{
		get => dic.ContainsKey(key) ? dic[key] : default(Value);
		set => dic[key] = value;
	}

}

class Program()
{
	static void Main(string[] args)
	{
		MyIndexer<string, string> myIndexer = new MyIndexer<string, string>();
		myIndexer["A"] = "A_Key";
		myIndexer["B"] = "B_Key";

		Console.WriteLine(myIndexer["A"]);
		Console.WriteLine(myIndexer["C"]); // 기본값 (공백)
		Console.WriteLine(myIndexer["B"]);

	}
}