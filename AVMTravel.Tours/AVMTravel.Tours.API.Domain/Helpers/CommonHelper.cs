namespace AVMTravel.Tours.API.Domain.Helpers
{
    public static class CommonHelper
    {
        public static string CannotBeEmptyMessage(string entityName)
            => $"The {entityName} cannot be empty";

        public static string IndalidFormatMessage(string entityName)
            => $"{entityName} invalid format";
    }
}
