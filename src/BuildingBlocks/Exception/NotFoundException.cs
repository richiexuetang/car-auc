namespace CarAuc.BuildingBlocks.Exception
{
    public class NotFoundException : CustomException
    {
        public NotFoundException(string message, int? code = null) : base(message, code: code)
        {
        }
    }
}
