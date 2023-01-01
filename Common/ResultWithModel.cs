namespace GM.Model.Common
{
    public class ResultWithModel
    {
        public ResultWithModel()
        {
            Success = false;
            RefCode = 0;
            Serverity = "None";
            Message = string.Empty;
            Data = new object();
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public int HowManyRecord { get; set; }
        // public int Total { get; set; }
        public object Data { get; set; }
        public int RefCode { get; set; }
        public string Serverity { get; set; }
    }

    public class ResultWithModel<T>
    {
        public ResultWithModel()
        {
            Success = false;
            RefCode = 0;
            Serverity = "None";
            Message = string.Empty;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public int HowManyRecord { get; set; }
        //public int Total { get; set; }
        public T Data { get; set; }
        public int RefCode { get; set; }
        public string Serverity { get; set; }
    }
}