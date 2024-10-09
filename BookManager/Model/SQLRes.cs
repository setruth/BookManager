namespace BookManager.Model
{
    public class SQLRes<T>
    {
        public T Data { get; set; }
        public string Msg { get; set; }

        public SQLRes(string msg, T data)
        {
            Data = data;
            Msg = msg;
        }

        public void Deconstruct(out string msg, out T data)
        {
            msg = Msg;
            data = Data;
        }
    }
}