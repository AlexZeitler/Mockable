using System;
using System.IO;
using System.Security.AccessControl;

namespace Mockable.System.IO {
	public class Directory : IDirectory {
		public DirectoryInfo CreateDirectory(string path) {
			return global::System.IO.Directory.CreateDirectory(path);
		}

		public DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity) {
			return global::System.IO.Directory.CreateDirectory(path, directorySecurity);
		}

		public void Delete(string path) {
			global::System.IO.Directory.Delete(path);
		}

		public void Delete(string path, bool recursive) {
			global::System.IO.Directory.Delete(path, recursive);
		}

		public bool Exists(string path) {
			return global::System.IO.Directory.Exists(path);
		}
	}
}