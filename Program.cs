// ストラテジーデザインパターンサンプルプログラム
internal class Program
{
    private static void Main(string[] args)
    {
        // 使用するアルゴリズム
        IAlgorithm algorithm = new Algorithm1();
        // IAlgorithm algorithm = new Algorithm2();

        // アルゴリズム実行
        new AlgorithmExecuter(algorithm).DoProcess();
    }
}

// インターフェース
public interface IAlgorithm
{
    public void Process();
}

// アルゴリズム実行クラス
public class AlgorithmExecuter
{
    private IAlgorithm algorithm;
    public AlgorithmExecuter(IAlgorithm algorithm)
    {
        this.algorithm = algorithm;
    }

    public void DoProcess()
    {
        this.algorithm.Process();
    }
}

// 具体的な処理を定義するクラス
// アルゴリズム1
public class Algorithm1 : IAlgorithm
{
    public void Process()
    {
        Console.WriteLine("A");
    }
}

// アルゴリズム2
public class Algorithm2 : IAlgorithm
{
    public void Process()
    {
        Console.WriteLine("B");
    }
}