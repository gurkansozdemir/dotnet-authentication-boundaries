public sealed record DemoPrincipal(string Subject, IReadOnlySet<string> Permissions);

public static class DemoAuthorization
{
    public static bool CanRead(DemoPrincipal principal) => principal.Permissions.Contains("sample:read");
}
