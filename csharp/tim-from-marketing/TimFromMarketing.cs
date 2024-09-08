using System;

static class Badge
{
    public static string Print(int? id, string name, string? department) =>
        $"{(id.HasValue ? $"[{id.ToString()}] - " : String.Empty)}{name} - {department?.ToUpperInvariant() ?? "OWNER"}";
}
