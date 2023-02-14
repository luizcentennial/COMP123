using System;
using System.IO;

namespace Example12 {
	class Program {
		static void Main(string[] args) {
			// FILE IO:
			// A set of techniques that can be used to read/write files from/to a hard-drive.

			// Examples:
			string root = @"C:\test\";

			// Retrieving directories from root:
			string[] folders = Directory.GetDirectories(root);

			foreach (string folder in folders) {
				Console.WriteLine(folder);
			}

			// Retrieving files from root:
			string[] files = Directory.GetFiles(root);

			foreach (string file in files) {
				Console.WriteLine(file);
			}

			// Check if directory exists:
			if (Directory.Exists(root)) {
				Console.WriteLine($"Folder '{root}' exists.");
			}
			else {
				Console.WriteLine($"Folder '{root}' does not exist.");
			}
		}
	}
}
