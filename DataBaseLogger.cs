namespace ArbreSoft.Logging
{
    // TODO: implement as independet class (cs from configuration?)
    public class DataBaseLogger : Logger
    {
        // private readonly ICrudRepository repository;

        // public DataBaseLogger(ICrudRepository reoisitory)
        // {
        //     this.repository = reoisitory;
        // }

        public override bool IsComposite()
        {
            return false;
        }

        public override void Log(string message)
        {
            // var log = new Log();
            // log.DateTime = TimeUtil.UtcNow();
            // log.Message = message;
            // repository.Add(log);
        }
    }
}