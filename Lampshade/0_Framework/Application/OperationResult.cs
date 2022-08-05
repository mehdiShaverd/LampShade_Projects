namespace _0_Framework.Application
{
    public class OperationResult
    {
        public bool IsSuccedded { get; set; }
        public string Massage { get; set; }

        public OperationResult()
        {
            IsSuccedded = false;
        }

        public OperationResult Succedded(string message = "عملیات با موفقیت انجام شد")
        {
            IsSuccedded = true;
            Massage = message;
            return this;
        }

        public OperationResult Failed(string message)
        {
            IsSuccedded = false;
            Massage = message;
            return this;
        }
    }
}
