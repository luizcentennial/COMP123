using System;
using System.IO;

namespace Example12 {
	class Program {
		static void Main(string[] args) {
			// FILE IO:
			// A set of techniques that can be used to read/write files from/to a hard-drive.
			string root = @"C:\test\";

			// Checking if directory exists:
			if (Directory.Exists(root)) {
				Console.WriteLine($"Folder '{root}' exists.");

				// Retrieving directories from folder:
				string[] folders = Directory.GetDirectories(root);

				foreach (string folder in folders) {
					Console.WriteLine(folder);
				}

				// Retrieving files from folder:
				string[] files = Directory.GetFiles(root);

				foreach (string file in files) {
					Console.WriteLine(file);
				}
			}
			else {
				Console.WriteLine($"Folder '{root}' does not.");
			}
		}
	}
}
