using System;

class SampleCollection<T>
{
    private T[] arr = new T[100];
    public T this[int i]   //注意，定义索引器。this 关键字用于定义索引器。
    {
        get
        {
            return arr[i]; //访问器采用参数
        }
        set
        {
            arr[i] = value; //访问器采用参数
        }
    }
}

// This class shows how client code uses the indexer
class Program
{
    static void Main(string[] args)
    {
        SampleCollection<string> stringCollection = new SampleCollection<string>();
        stringCollection[0] = "Hello, World"; //这里 使用索引器进行引用
        System.Console.WriteLine(stringCollection[0]);
    }
}