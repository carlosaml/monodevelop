// 
// XmlFormatter.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@novell.com>
// 
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
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
using System.IO;
using System.Xml;
using System.Collections.Generic;
using MonoDevelop.Ide.Gui.Content;
using MonoDevelop.Ide;
using MonoDevelop.Projects.Text;
using MonoDevelop.Projects.Policies;

namespace MonoDevelop.Xml.Formatting
{
	public class XmlFormatter: IPrettyPrinter
	{
		public bool CanFormat (string mimeType)
		{
			return DesktopService.GetMimeTypeIsSubtype (mimeType, "application/xml");
		}
		
		public string FormatXml (TextStylePolicy textPolicy, XmlFormattingPolicy formattingPolicy, string input)
		{
			XmlDocument doc;
			try {
				doc = new XmlDocument ();
				doc.LoadXml (input);
			} catch {
				// Ignore malformed xml
				return input;
			}
			
			StringWriter sw = new StringWriter ();
			XmlFormatterWriter xmlWriter = new XmlFormatterWriter (sw);
			xmlWriter.WriteNode (doc, formattingPolicy, textPolicy);
			xmlWriter.Flush ();
			return sw.ToString ();
		}
		public void CorrectIndenting (object textEditorData, int line)
		{
			// TODO
		}
		
		public void OnTheFlyFormat (object textEditorData, MonoDevelop.Projects.Dom.IType callingType, MonoDevelop.Projects.Dom.IMember callingMember, MonoDevelop.Projects.Dom.Parser.ProjectDom dom, MonoDevelop.Projects.Dom.ICompilationUnit unit, MonoDevelop.Projects.Dom.DomLocation endLocation)
		{
			throw new System.NotImplementedException();
		}
		
		public void OnTheFlyFormat (PolicyContainer policyParent, object textEditorData, int startOffset, int endOffset)
		{
			throw new NotImplementedException ();
		}
		
		public string FormatText (PolicyContainer policyParent, string mimeType, string input)
		{
			XmlFormattingPolicy xmlPol = policyParent.Get<XmlFormattingPolicy> (mimeType);
			TextStylePolicy txtPol = policyParent.Get<TextStylePolicy> (mimeType);
			return FormatXml (txtPol, xmlPol, input);
		}
		
		public string FormatText (PolicyContainer policyParent, string mimeType, string input, int fromOffest, int toOffset)
		{
			return input;
		}
		
		public bool SupportsOnTheFlyFormatting {
			get {
				return false;
			}
		}
	}
}
