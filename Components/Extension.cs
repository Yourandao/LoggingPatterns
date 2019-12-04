using System.Linq;

public static class Extension {
	public static bool IsOneOf<T>(this T self, params T[] cases) {
		return cases.Contains(self);
	}
}