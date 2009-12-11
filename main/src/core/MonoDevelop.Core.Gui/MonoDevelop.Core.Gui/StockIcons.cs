// StockIcons.cs
//
// Author:
//   Lluis Sanchez Gual <lluis@novell.com>
//
// Copyright (c) 2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//


using System;

namespace MonoDevelop.Core.Gui
{
	public class Stock
	{
		public static readonly string AddNamespace = "md-add-namespace";
		public static readonly string BreakPoint = "md-break-point";
		public static readonly string BuildCombine = "md-build-combine";
		public static readonly string BuildCurrentSelectedProject = "md-build-current-selected-project";
		public static readonly string Class = "md-class";
		public static readonly string ClearAllBookmarks = "md-clear-all-bookmarks";
		public static readonly string CloseAllDocuments = "md-close-all-documents";
		public static readonly string CloseCombine = "md-close-combine-icon";
		public static readonly string CloseIcon = Gtk.Stock.Close;
		public static readonly string ClosedFolder = "md-closed-folder";
		public static readonly string ClosedReferenceFolder = "md-closed-reference-folder";
		public static readonly string ClosedResourceFolder = "md-closed-resource-folder";
		public static readonly string Solution = "md-solution";
		public static readonly string Workspace = "md-workspace";
		public static readonly string CopyIcon = Gtk.Stock.Copy;
		public static readonly string CutIcon = Gtk.Stock.Cut;
		public static readonly string Delegate = "md-delegate";
		public static readonly string DeleteIcon = Gtk.Stock.Delete;
		public static readonly string Empty = "md-empty";
		public static readonly string EmptyFileIcon = "md-empty-file-icon";
		public static readonly string Enum = "md-enum";
		public static readonly string Error = Gtk.Stock.DialogError;
		public static readonly string Event = "md-event";
		public static readonly string ExecutionMarker = "md-execution-marker";
		public static readonly string Field = "md-field";
		public static readonly string FileXmlIcon = "md-file-xml-icon";
		public static readonly string FindIcon = Gtk.Stock.Find;
		public static readonly string FindInFiles = "md-find-in-files";
		public static readonly string FindNextIcon = "md-find-next-icon";
		public static readonly string FullScreen = Gtk.Stock.Fullscreen;
		public static readonly string GotoNextbookmark = "md-goto-nextbookmark";
		public static readonly string GotoPrevbookmark = "md-goto-prevbookmark";
		public static readonly string Information = Gtk.Stock.DialogInfo;
		public static readonly string Interface = "md-interface";
		public static readonly string InternalClass = "md-internal-class";
		public static readonly string InternalDelegate = "md-internal-delegate";
		public static readonly string InternalEnum = "md-internal-enum";
		public static readonly string InternalEvent = "md-internal-event";
		public static readonly string InternalField = "md-internal-field";
		public static readonly string InternalInterface = "md-internal-interface";
		public static readonly string InternalMethod = "md-internal-method";
		public static readonly string InternalProperty = "md-internal-property";
		public static readonly string InternalStruct = "md-internal-struct";
		public static readonly string Literal = "md-literal";
		public static readonly string Method = "md-method";
		public static readonly string MiscFiles = "md-misc-files";
		public static readonly string NameSpace = "md-name-space";
		public static readonly string NewDocumentIcon = Gtk.Stock.New;
		public static readonly string NewFolderIcon = "md-new-folder-icon";
		public static readonly string NewProjectIcon = "md-new-project-icon";
		public static readonly string NextWindowIcon = Gtk.Stock.GoForward;
		public static readonly string OpenFileIcon = Gtk.Stock.Open;
		public static readonly string OpenFolder = "md-open-folder";
		public static readonly string OpenProjectIcon = "md-open-project-icon";
		public static readonly string OpenReferenceFolder = "md-open-reference-folder";
		public static readonly string OpenResourceFolder = "md-open-resource-folder";
		public static readonly string Options = Gtk.Stock.Preferences;
		public static readonly string OutputIcon = "md-output-icon";
		public static readonly string PasteIcon = Gtk.Stock.Paste;
		public static readonly string PreView = Gtk.Stock.PrintPreview;
		public static readonly string PrevWindowIcon = Gtk.Stock.GoBack;
		public static readonly string Print = Gtk.Stock.Print;
		public static readonly string PrivateClass = "md-private-class";
		public static readonly string PrivateDelegate = "md-private-delegate";
		public static readonly string PrivateEnum = "md-private-enum";
		public static readonly string PrivateEvent = "md-private-event";
		public static readonly string PrivateField = "md-private-field";
		public static readonly string PrivateInterface = "md-private-interface";
		public static readonly string PrivateMethod = "md-private-method";
		public static readonly string PrivateProperty = "md-private-property";
		public static readonly string PrivateStruct = "md-private-struct";
		public static readonly string PropertiesIcon = "md-properties-icon";
		public static readonly string Property = "md-property";
		public static readonly string ProtectedClass = "md-protected-class";
		public static readonly string ProtectedDelegate = "md-protected-delegate";
		public static readonly string ProtectedEnum = "md-protected-enum";
		public static readonly string ProtectedEvent = "md-protected-event";
		public static readonly string ProtectedField = "md-protected-field";
		public static readonly string ProtectedInterface = "md-protected-interface";
		public static readonly string ProtectedMethod = "md-protected-method";
		public static readonly string ProtectedProperty = "md-protected-property";
		public static readonly string ProtectedStruct = "md-protected-struct";
		public static readonly string Question = Gtk.Stock.DialogQuestion;
		public static readonly string QuitIcon = Gtk.Stock.Quit;
		public static readonly string RedoIcon = Gtk.Stock.Redo;
		public static readonly string Reference = "md-reference";
		public static readonly string ReplaceIcon = Gtk.Stock.FindAndReplace;
		public static readonly string ReplaceInFiles = "md-replace-in-files";
		public static readonly string ResourceFileIcon = "md-resource-file-icon";
		public static readonly string RunProgramIcon = Gtk.Stock.Execute;
		public static readonly string SaveAllIcon = "md-save-all-icon";
		public static readonly string SaveAsIcon = Gtk.Stock.SaveAs;
		public static readonly string SaveIcon = Gtk.Stock.Save;
		public static readonly string MonoDevelop = "md-monodevelop";
		public static readonly string Project = "md-project";
		public static readonly string SplitWindow = "md-split-window";
		public static readonly string Struct = "md-struct";
		public static readonly string TaskListIcon = "md-task-list-icon";
		public static readonly string TextFileIcon = "md-text-file-icon";
		public static readonly string TipOfTheDay = "md-tip-of-the-day";
		public static readonly string ToggleBookmark = "md-toggle-bookmark";
		public static readonly string UndoIcon = Gtk.Stock.Undo;
		public static readonly string Warning = Gtk.Stock.DialogWarning;
		public static readonly string WebSearchIcon = "md-web-search-icon";
		public static readonly string XmlFileIcon = "md-xml-file-icon";
		public static readonly string Addin = "md-addin";
		public static readonly string SolutionFolderOpen = "md-solution-folder-open";
		public static readonly string SolutionFolderClosed = "md-solution-folder-closed";

	}
}