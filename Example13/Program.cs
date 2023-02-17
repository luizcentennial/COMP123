using System;
using System.IO;

namespace Example13 {
	class Program {
		static void Main(string[] args) {
			// FILE IO (cont.):
			string root = @"C:\test\";

			// Programatically creating files:
			for (int i = 0; i < 3; i++) {
				string filename = $"file {i}.txt";

				File.WriteAllText(root + filename, $"'{filename}' was created programatically.");
			}

			// Programatically reading files:
			string[] files = Directory.GetFiles(root);

			foreach (string file in files) {
				string content = File.ReadAllText(file);

				if (!string.IsNullOrWhiteSpace(content)) {
					Console.WriteLine(content);
					Console.WriteLine("-------------------- End of file. --------------------\n");
				}
			}

			// Programatically deleting files:
			foreach (string file in files) {
				if (File.Exists(file)) {
					File.Delete(file);
				}
			}
		}
	}
}
