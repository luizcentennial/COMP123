using System;
using System.IO;

namespace Example13 {
	class Program {
		static void Main(string[] args) {
			// FILE IO (cont.):

			// Loading file contents:
			string root = @"C:\test\";

			string[] files = Directory.GetFiles(root);

			foreach (string file in files) {
				string contents = File.ReadAllText(file);

				if (!string.IsNullOrWhiteSpace(contents)) {
					Console.WriteLine(contents);
					Console.WriteLine("-------------------- End of file. --------------------\n");
				}
			}

			// Erasing file contents:
			foreach (string file in files) {
				Console.WriteLine($"Erasing file '{file}'...");

				File.WriteAllText(file, string.Empty);

				Console.WriteLine("Done.");
			}

			// Creating files:
			File.WriteAllText(root + "file 3.txt", "This file was created dynamically.");
		}
	}
}
