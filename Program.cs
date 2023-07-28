public class Program {
    public static void Main() {
        // String[] names = new String[3];
        // names[0] = "Harry";
        // names[1] = "Ron";
        // names[2] = "Hermione";

        String[] names = {"Harry", "Ron", "Hermione"};
        for(int i = 0; i < names.Count(); i++) {
            Console.WriteLine(names[i]);
        }
        foreach (String s in names) {
            Console.WriteLine(s);
        }
    }

    public static string Capitalize(string s) {
        return s[0].ToString().ToUpper() + s.Substring(1).ToLower();
    }
}