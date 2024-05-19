namespace OrderDeliverySystem.AdministrationPanel.Services
{
    public struct Result<T, E>
    {
        public T Value { get; }
        public E Error { get; }
        public bool IsSuccess { get; }

        private Result(T value, E error, bool isSuccess)
        {
            Value = value;
            Error = error;
            IsSuccess = isSuccess;
        }

        public static Result<T, E> Ok(T value) => new Result<T, E>(value, default, true);
        public static Result<T, E> Err(E error) => new Result<T, E>(default, error, false);
    }
}
