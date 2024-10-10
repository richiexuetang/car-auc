namespace CarAuc.BuildingBlocks.Exception
{
    public class BadRequestException : CustomException
    {
        public BadRequestException(string message, int? code = null) : base(message, code: code)
        {

        }
    }
}
