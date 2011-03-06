using System;
using System.IO;
using System.Security;
using System.Security.AccessControl;

namespace Mockable.System.IO {
	/// <summary>
	/// Exposes methods for creating, moving, and enumerating through directories and subdirectories.
	/// </summary>
	public interface IDirectory {
		/// <summary>
		/// Creates all directories and subdirectories as specified by path.
		/// </summary>
		/// <param name="path">The directory path to create.</param>
		/// <returns>A <see cref="T:System.IO.DirectoryInfo" /> as specified by path.</returns>
		/// <exception cref="ArgumentNullException">path is null.</exception>
		/// <exception cref="UnauthorizedAccessException">The caller does not have the required permission.</exception>
		/// <exception cref="IOException">The directory specified by path is read-only or is not empty.-or-A file with the same name and location specified by path exists.</exception>
		/// <exception cref="NotSupportedException">An attempt was made to create a directory with only the colon character (:). </exception>
		/// <exception cref="ArgumentException">path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />
		/// 	.</exception>
		/// <exception cref="PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		[SecuritySafeCritical]
		DirectoryInfo CreateDirectory(string path);

		/// <summary>
		/// Creates all the directories in the specified path, applying the specified Windows security.
		/// </summary>
		/// <param name="path">The directory path to create.</param>
		/// <param name="directorySecurity">The access control to apply to the directory.</param>
		/// <returns>A <see cref="T:System.IO.DirectoryInfo" /> object representing the newly created directory.</returns>
		[SecuritySafeCritical]
		DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity);

		[SecuritySafeCritical]
		void Delete(string path);

		[SecuritySafeCritical]
		void Delete(string path, bool recursive);

		/// <summary>
		/// Determines whether the given path refers to an existing directory on disk.
		/// </summary>
		/// <param name="path">The path to test.</param>
		/// <returns>true if path refers to an existing directory; otherwise, false.</returns>
		bool Exists(string path);
	}
}