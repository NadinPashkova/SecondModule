namespace SecondModule.Providers
{
    internal static class ParsePatternProvider
    {
        public const string FileNamePattern = @"(^[a-zA-Z0-9]+([a-zA-Z\\_0-9\.-]*))";
        public const string SizePattern = @"\((.+)\)";
        public const string ResolutionPattern = @"(\d+x\d+)";
        public const string LengthPattern = @"(\d+h\d+)";
    }
}
