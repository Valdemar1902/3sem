namespace mit_console_projekt.Opgaver;

class Opgave5 {
    public static void ScanDir(string path, string prefix) {
        DirectoryInfo dir = new DirectoryInfo(path);
        FileInfo[] files = dir.GetFiles();

        // Udskriver alle filerne
        foreach (FileInfo file in files) {
            Console.WriteLine(prefix + file.Name);
        }
        DirectoryInfo[] dirs = dir.GetDirectories();

        // Kalder rekursivt på alle undermapper
        foreach (DirectoryInfo subdir in dirs) {
            Console.WriteLine(prefix + subdir.Name);
            ScanDir(subdir.FullName, prefix + "  ");
            
        }        
    }
}