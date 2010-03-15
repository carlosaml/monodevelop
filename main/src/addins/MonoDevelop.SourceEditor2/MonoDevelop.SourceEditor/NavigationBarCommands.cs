// 
// NavigationBarCommands.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
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

using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Core;
using MonoDevelop.Ide.Gui;

namespace MonoDevelop.SourceEditor
{
	public enum NavigationBarCommands {
		ToggleNavPanelViews
	}
	
	class ToggleNavPanelViewsHandler : CommandHandler 
	{
		protected override void Run (object data)
		{
			Action action = data as Action;
			if (action != null)
				action ();
		}
		
		protected override void Update (CommandArrayInfo ainfo)
		{
			ainfo.Add (NavigationBar.HideStatusBox ? GettextCatalog.GetString ("_Show Caret Panel") : GettextCatalog.GetString ("_Hide Caret Panel"), new System.Action (delegate {
				IdeApp.Workbench.StatusBar.ClearCaretState ();
				NavigationBar.HideStatusBox = !NavigationBar.HideStatusBox;
			}));
			
			if (!NavigationBar.HideStatusBox) {
				ainfo.Add (StatusBox.ShowRealColumns ? GettextCatalog.GetString ("_Show logical caret position") : GettextCatalog.GetString ("_Show visual caret position") , new System.Action (delegate {
					StatusBox.ShowRealColumns = !StatusBox.ShowRealColumns;
				}));
			}
		}
	}
	
	
}
